using System.Net;
using GuessTheNameServer.Networking;
using GuessTheNameServer.Utilities;
using Shared;
using Shared.ProtocolModels;
namespace GuessTheNameServer.ServerCore
{
    public class GameServer
    {
        private readonly ServerNetwork _network;
        //private static readonly RoomManager _roomManager = new();
        


        public GameServer() =>
            _network = new ServerNetwork();

        public async Task Start()
        {
           await _network.StartListeningAsync();
        }
    }
}