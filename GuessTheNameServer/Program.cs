using GuessTheNameServer.ServerCore;
using GuessTheNameServer.Utilities;

namespace GuessTheNameServer
{
    class Program
    {
        static async Task Main()
        {
            Logger.Log("Starting server...");
            try
            {
                var gameServer = new GameServer();
                await gameServer.Start();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Logger.Log($"Critical error: {ex.Message}");
                Logger.Log($"Stack trace: {ex.StackTrace}");
            }
        }
    }
}