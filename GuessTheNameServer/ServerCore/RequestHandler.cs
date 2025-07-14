using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNameServer.Utilities;
using Newtonsoft.Json;
using Shared.ProtocolModels;
using Shared.Requests;

namespace GuessTheNameServer.ServerCore
{
    public static class RequestHandler
    {
        public static async Task HandleRequest(Player player, GameCommand command)
        {

            GameCommand invalidRequest = new GameCommand() { Action = "Invalid request"};
            if (string.IsNullOrEmpty(command.Data))
            {
                await SendResponse(player, invalidRequest);
                return;
            }
            try
            {
                switch (command.Action)
                {
                    case "Login":
                    {
                        player.Name = command.Data;
                        await RoomManager.RoomManger.GoToLobby(player);
                        break;
                    }

                    case "Create room":
                    {
                        RoomManager.RoomManger.CreateRoom(player, command.Data);
                        break;
                    }
                    case "Join room":
                    {
                        JoinRoom joinRoomRequestData = JsonConvert.DeserializeObject<JoinRoom>(command.Data)!;
                        if (joinRoomRequestData?.RoomId != null)
                        {
                            await RoomManager.RoomManger.AskToJoin(player, joinRoomRequestData.RoomId);
                        }
                        else
                        {
                            await SendResponse(player, invalidRequest);
                        }
                        break;
                    }
                    case "Guess":
                    {
                        GuessLetter guess = JsonConvert.DeserializeObject<GuessLetter>(command.Data)!;
                        if (char.IsLetter(guess.Letter) && player.RoomId is Guid roomId)
                        {
                            var room = RoomManager.RoomManger.GetRoom(player.RoomId.Value);
                        }
                        else
                        {
                            await SendResponse(player, invalidRequest);
                        }
                        break;
                    }
                    case "Spectate":
                    {
                        SpectateGame spectateGameRequest = JsonConvert.DeserializeObject<SpectateGame>(command.Data)!;
                        if (player.RoomId is Guid roomId)
                        {
                            await RoomManager.RoomManger.Spectate(player, roomId);
                        }
                        else
                        {
                            await SendResponse(player, invalidRequest);
                        }
                        break;
                    }
                    case "Rematch":
                    {
                        if (player.RoomId is Guid roomId)
                        {
                            var room = RoomManager.RoomManger.GetRoom(roomId);
                            await room.HandleRematch(player, true);
                        }
                        else
                        {
                            await SendResponse(player, invalidRequest);
                        }
                        break;
                    }
                    case "End game":
                    {
                        if (player.RoomId is Guid roomId)
                        {
                            var room = RoomManager.RoomManger.GetRoom(roomId);
                            await room.HandleRematch(player, false);
                        }
                        else
                        {
                            await SendResponse(player, invalidRequest);
                        }
                        break;
                    }
                    default:
                        await SendResponse(player, invalidRequest);
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"{ex.Message}");
            }

        }

        public static async Task SendResponse(Player player, GameCommand command)
        {
            string gameCommand = JsonConvert.SerializeObject(command);
            try
            {
                await player.Writer.WriteAsync(gameCommand);
            }
            catch(Exception ex)
            {
                Logger.Log($"Error sending to player {player.Name}: {ex.Message}");
            }
        }
    }
    
}
