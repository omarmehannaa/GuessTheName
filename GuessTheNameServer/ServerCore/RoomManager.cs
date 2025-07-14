
using System.ComponentModel;
using GuessTheNameServer.Utilities;
using Newtonsoft.Json;
using Shared;
using Shared.ProtocolModels;


namespace GuessTheNameServer.ServerCore
{
    public class RoomManager
    {
        private readonly Dictionary<Guid, Room> _rooms = new();
        private static RoomManager _roomManager;
        private static object _lock = new();
        public static RoomManager RoomManger
        {
            get
            {
                lock(_lock)
                {
                    if (_roomManager == null)
                    {
                        _roomManager = new RoomManager();
                    }
                    return _roomManager;
                }
            }
        }
        private RoomManager() { }

        public async Task GoToLobby(Player player)
        {
            var lobbyInfo = _rooms.Values.Select(room => new LobbyRoomInfo
            {
                RoomId = room.RoomId,
                Category = room.Category,
                IsGameAcceptOpponent = room.IsGameAcceptOpponent
            }).ToList();

            var gameCommand = new GameCommand
            {
                Action = "Go to Lobby",
                Data = JsonConvert.SerializeObject(lobbyInfo)
            };

            string lobbyCommand = JsonConvert.SerializeObject(gameCommand);
            try
            {
                await player.Writer.WriteLineAsync(lobbyCommand);
                player.state = "In lobby";
            }
            catch (Exception ex)
            {
                Logger.Log($"Error sending to player {player.Name}: {ex.Message}");
            }
        }

        
        public void CreateRoom(Player player, string category)
        {
            var room = new Room(player, category);
            _rooms.Add(room.RoomId, room);
            player.RoomId = room.RoomId;
            player.state = "Waiting opponent";
        }

        public Room GetRoom(Guid roomId)
        {
            Room room = _rooms[roomId];
            return room;
        }
        public async Task AskToJoin(Player player, Guid roomId)
        {
            GameCommand command = new GameCommand();
            Room room = _rooms[roomId];
            if (room.IsGameAcceptOpponent)
            {
                bool joinRequest = await room.SendJoinRequestToHost(player.Name);
                if (joinRequest)
                {
                    command.Action = "Waiting to join";
                    player.state = "Wating to join";
                }
            }
            else
            {
                command.Action = "Room is full";
            }
            try
            {
                player.Writer.WriteLine(JsonConvert.SerializeObject(command));  
            }
            catch (Exception ex)
            {
                Logger.Log($"Error sending to player {player.Name}: {ex.Message}");
            }
        }

        public async Task Spectate(Player spectator, Guid roomId)
        {
            Room room = _rooms[(roomId)];
            await room.AddSpectator(spectator);
        }

        public void RemoveRoom(Guid roomId)
        {
            lock (_lock)
            {
                if (_rooms.ContainsKey(roomId))
                {
                    _rooms.Remove(roomId);
                    Logger.Log($"Room {roomId} removed from RoomManager.");
                }
                else
                {
                    Logger.Log($"Attempted to remove room {roomId}, but it was not found.");
                }
            }
        }

    }
}