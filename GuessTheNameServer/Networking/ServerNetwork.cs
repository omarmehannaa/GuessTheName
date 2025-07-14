using System.Net;
using System.Net.Sockets;
using System.Xml.Linq;
using GuessTheNameServer.ServerCore;
using GuessTheNameServer.Utilities;
using Newtonsoft.Json;
using Shared;
using Shared.ProtocolModels;

namespace GuessTheNameServer.Networking
{
    public class ServerNetwork
    {
        private readonly TcpListener _listener;
        private readonly RoomManager _roomManager;
        private readonly IPAddress _ip = ConnectionInformation.IPAddress;
        private readonly int _port = ConnectionInformation.Port;

        public ServerNetwork(int port, RoomManager roomManager)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _roomManager = roomManager;
        }
        public ServerNetwork()
        {
            _listener = new TcpListener(_ip, _port);
            Logger.Log($"Server started on port {ConnectionInformation.Port}");
        }

        public async Task StartListeningAsync()
        {
            
            _listener.Start();
            Logger.Log("Server ready for connections");
            while (true)
            {
                var client = await _listener.AcceptTcpClientAsync();
                var _ = HandleClientAsync(client);
            }

        }

        private async Task HandleClientAsync(TcpClient client)
        {
            using var player = new Player(client);
            try
            {
                while (client.Connected)
                {
                    var message = await player.Reader.ReadLineAsync();
                    if (string.IsNullOrEmpty(message)) continue;

                    var command = JsonConvert.DeserializeObject<GameCommand>(message);

                    await RequestHandler.HandleRequest(player, command);
                    
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Connection error: {ex.Message}");
            }
            finally
            {
                client.Close();
                Logger.Log($"Client disconnected: {client.Client.RemoteEndPoint}");



            }
        }
    }
}