using GuessTheNameClient.Networking;
using Shared.ProtocolModels;

namespace GuessTheNameClient.ClientCore
{
    public class GameClient
    {
        private readonly ClientNetwork _network = new();

        // Expose the network's connection state

        public ClientNetwork Network => _network;
        public bool IsConnected => _network?.IsConnected ?? false;


        public async Task Connect(string ip, int port)
        {
            if (!IsConnected)
                await _network.ConnectAsync(ip, port);
        }

        public async Task SendCommand(ProtocolModels command)
        {
            if (!IsConnected)
                throw new InvalidOperationException("Not connected to server");

            await _network.SendCommandAsync(command);
        }
    }
}