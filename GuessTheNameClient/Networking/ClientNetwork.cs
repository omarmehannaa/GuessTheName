using System.Net.Sockets;
using Newtonsoft.Json;
using Shared.ProtocolModels;

namespace GuessTheNameClient.Networking
{
    public class ClientNetwork
    {
        private TcpClient? _client;
        private StreamReader? _reader;
        private StreamWriter? _writer;

        public bool IsConnected => _client?.Connected == true && _writer != null;

        public async Task TestSerializationAsync()
        {
            if (!IsConnected)
                throw new InvalidOperationException("Not connected to server");

            try
            {
                var testCommand = new ProtocolModels
                {
                    Action = "TEST_SERIALIZATION",
                    Data = "Hello Server!"
                };

                await _writer!.WriteLineAsync(JsonConvert.SerializeObject(testCommand));
                await _writer.FlushAsync();
            }
            catch
            {
                throw new InvalidOperationException("Failed to send test command");
            }
        }

        public async Task ConnectAsync(string ip, int port = 8888)
        {
            try
            {
                _client = new TcpClient();
                await _client.ConnectAsync(ip, port);
                _reader = new StreamReader(_client.GetStream());
                _writer = new StreamWriter(_client.GetStream());
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Connection failed", ex);
            }
        }

        public async Task SendCommandAsync(ProtocolModels command)
        {
            if (!IsConnected || _writer == null)
                throw new InvalidOperationException("Not connected to server");

            await _writer.WriteLineAsync(JsonConvert.SerializeObject(command));
            await _writer.FlushAsync();
        }
    }
}