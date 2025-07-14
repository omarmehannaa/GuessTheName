using System.ComponentModel;
using System.Numerics;
using System.Text;
using System.Text.Json;
using GuessTheNameServer.Utilities;
using Newtonsoft.Json;
using Shared.ProtocolModels;
using Shared.Requests;
using Shared.Responses;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace GuessTheNameServer.ServerCore
{
    public class Room
    {
        public Guid RoomId { get; } = Guid.NewGuid();
        public string Category { get; set; } = null!;
        private List<Player> _players = new List<Player>(2);
        private string _secretWord;
        private List<char> _guessedLetters { get; set; }
        public bool IsGameActive { get; private set; }
        private int _currentPlayerIndex { get; set; }

        private List<Player> _spectators { get; set; } = new();
        private GameLogic _gameLogic { get; set; }
        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);
        public bool IsGameAcceptOpponent { get; set; } = true;

        public Room(Player player, string category)
        {
            _players.Add(player);
            Category = category;
            _guessedLetters = new List<char>(); 
        }

        private async Task CreateNewGame()
        {
            _secretWord = await WordLoader.LoadRandomWord(Category);
            _guessedLetters = Enumerable.Repeat('_', _secretWord.Length).ToList();
            _gameLogic = new GameLogic(_secretWord);
            _currentPlayerIndex = 0;
            IsGameAcceptOpponent = false;
        }

        private async Task StartGame()
        {
            if (_players.Count == 2)
            {
                await CreateNewGame();
                IsGameActive = true;
                GameCommand start = new GameCommand()
                {
                    Action = "Start the game",
                    Data = JsonConvert.SerializeObject(_guessedLetters)

                };
                string startCommand = JsonConvert.SerializeObject(start);
                foreach(Player player in _players)
                {
                    await SendToPlayerAsync(player ,startCommand);
                    player.state = "Playing";
                }
                GameCommand yourturn = new GameCommand()
                {
                    Action = "Your turn"
                };
                string yourTurnCommand = JsonConvert.SerializeObject( yourturn);
                await SendToPlayerAsync(_players[0], yourTurnCommand);
            }
        }

        public async Task AddSpectator(Player spectator)
        {
            await _lock.WaitAsync();
            try
            {
                if (!IsGameActive || _players.Count < 2) return;
                _spectators.Add(spectator);
                StartSpectate startSpectate = new StartSpectate()
                {
                    Players = [_players[0].Name, _players[1].Name],
                    Word = _guessedLetters,
                    IndexOfCurrentPlayer = _currentPlayerIndex
                };
                GameCommand spectateCommand = new GameCommand()
                {
                    Action = "Start spectate",
                    Data = JsonConvert.SerializeObject(startSpectate)
                };
                string startSpectateCommand = JsonConvert.SerializeObject(spectateCommand);
                await SendToPlayerAsync(spectator, startSpectateCommand);
                spectator.state = "Spectating";
            }
            finally
            {
                _lock.Release();
            }
        }

        public async Task<bool> SendJoinRequestToHost (string opponentName)
        {
            await _lock.WaitAsync();
            try
            {
                if (!IsGameAcceptOpponent || _players.Count == 2) return false;
                GameCommand askToJoin = new GameCommand()
                {
                    Action = "Join request",
                    Data = $"{opponentName} want to join"
                };
                string askToJoinCoomand = JsonConvert.SerializeObject(askToJoin);
                await SendToPlayerAsync(_players[0], askToJoinCoomand);
                return true;
            }
            finally
            {
                _lock.Release();
            }
        }

        public async Task<bool> AddOpponent(Player opponent)
        {
            await _lock.WaitAsync();
            try
            {
                if(_players.Count > 1 && IsGameActive)
                    return false;
                _players.Add(opponent);
                IsGameAcceptOpponent = false;
                opponent.RoomId = RoomId;
                GameCommand joinAccepted = new GameCommand()
                {
                    Action = "Join request accepted"
                };
                string joinAcceptedCommand = JsonConvert.SerializeObject(joinAccepted);
                await SendToPlayerAsync(_players[1], joinAcceptedCommand);
                await StartGame();
                return true;
            }
            finally
            {
                _lock.Release();
            }
        }

        public async Task ProcessGuess(Player player, char letter)
        {
            await _lock.WaitAsync();
            try
            {
                if (player != _players[_currentPlayerIndex])
                    return;
                bool isCorrect;
                bool isFinished;
                (isCorrect, isFinished) = _gameLogic.CheckLetter(_guessedLetters, letter);
                if(isFinished)
                {
                    await AskRematch();
                }
                else if(isCorrect)
                {
                    await SendUpdatedWord();
                }
                else
                {
                    int oldPlayerIndex = _currentPlayerIndex;
                    _currentPlayerIndex = (_currentPlayerIndex + 1) % 2;
                    await NotifyChangeTurn(_players[oldPlayerIndex]);
                    await NotifyYourTurn(_players[_currentPlayerIndex]);
                    await Notify_spectatorsTurnChanged();
                }
            }
            finally
            {
                _lock.Release();
            }
        }

        private async Task AskRematch()
        {
            GameCommand askRematch = new GameCommand() { Action = "Ask rematch" };
            string askRematchCommand = JsonConvert.SerializeObject(askRematch);
            foreach (var player in _players)
            {
                player.state = "Waiting rematch";
                await SendToPlayerAsync(player, askRematchCommand);
            }
        }
        private async Task SendUpdatedWord()
        {
            GameCommand updateTheWord = new GameCommand()
            {
                Action = "Update the word",
                Data = JsonConvert.SerializeObject(_guessedLetters)
            };
            string updateTheWordCommand = JsonConvert.SerializeObject(updateTheWord);
            await SendToAllAsync(updateTheWordCommand);
        }

        private async Task NotifyYourTurn(Player player)
        {
            GameCommand yourTurn = new GameCommand() { Action = "Your turn" };
            string yourTurnCommand = JsonConvert.SerializeObject(yourTurn);
            await SendToPlayerAsync(player, yourTurnCommand);
        }

        private async Task Notify_spectatorsTurnChanged()
        {
            GameCommand updateCurrentPlayerFor_spectators = new GameCommand()
            {
                Action = "Update current player",
                Data = _currentPlayerIndex.ToString()
            };
            string updateCurrentPlayerFor_spectatorsCommand = JsonConvert.SerializeObject(updateCurrentPlayerFor_spectators);
            await SendTo_spectatorsAsync(updateCurrentPlayerFor_spectatorsCommand);
        }

        private async Task NotifyChangeTurn(Player player)
        {
            GameCommand changeTurn = new GameCommand() { Action = "Change turn" };
            string changeTurnCommand = JsonConvert.SerializeObject(changeTurn);
            await SendToPlayerAsync(player, changeTurnCommand);
        }

        public async Task HandleRematch(Player player, bool rematch)
        {
            await _lock.WaitAsync();
            try
            {
                if (player == _players[0] && !rematch)
                {
                    await EndGame();
                }
                else if (rematch)
                {
                    player.state = "Want rematch";
                    if (_players[0].state == "Want rematch" &&  _players[1].state == "Want rematch")
                    {
                        _guessedLetters.Clear();
                        await StartGame();
                    }
                    else
                    {
                        GameCommand waitingTheOtherPlayer = new GameCommand() { Action = "Waiting rematch" };
                        string waitingTheOtherPlayerCommand = JsonConvert.SerializeObject(waitingTheOtherPlayer);
                        await SendToPlayerAsync(player, waitingTheOtherPlayerCommand);
                    }
                }
                else
                {
                    IsGameActive = false;
                    IsGameAcceptOpponent = false;
                    _players[1].RoomId = null;
                    _players.Remove(player);
                    _players[0].state = "Waiting opponent";
                    GameCommand waitingOpponent = new GameCommand() { Action = "Waiting other Opponent" };
                    string waitingOpponentCommand = JsonConvert.SerializeObject(waitingOpponent);
                    await SendToPlayerAsync(_players[0], waitingOpponentCommand);
                }
            }
            finally
            {
                _lock.Release();
            }
        }

        private async Task EndGame()
        {
            await _lock.WaitAsync();
            try
            {
                GameCommand endGame = new GameCommand()
                {
                    Action = "End game"
                };
                string endGameCommand = JsonConvert.SerializeObject(endGame);
                await SendToAllAsync(endGameCommand);
                foreach (var player in _players)
                {
                    RoomManager.RoomManger.GoToLobby(player);
                }
                foreach (var spectator in _spectators)
                {
                    RoomManager.RoomManger.GoToLobby(spectator);
                }
                _players[0].RoomId = null;
                _players[1].RoomId = null;

                RoomManager.RoomManger.RemoveRoom(RoomId);
            }
            finally
            {
                _lock.Release();
            }
        }

        private async Task SendToAllAsync(string command)
        {
            var allRecipients = _players.Concat(_spectators);
            await Task.WhenAll(allRecipients.Select(p =>  SendToPlayerAsync(p, command)));

        }
        private async Task SendToPlayerAsync(Player player, string command)
        {
            try
            {
                if (player.Writer == null)
                {
                    Logger.Log($"Writer is null for player {player.Name}");
                    return;
                }
                await player.Writer.WriteLineAsync(command);

            }
            catch (Exception ex)
            {
                Logger.Log($"Error sending to player {player.Name}: {ex.Message}");
            }
        }
        private async Task SendTo_spectatorsAsync(string command)
        {

            if (_spectators.Count > 0)
            {
               await Task.WhenAll(_spectators.Select(s => SendToPlayerAsync(s, command)));
            }
        }
    }
}