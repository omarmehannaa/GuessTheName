using Shared.ProtocolModels;
namespace GuessTheNameServer.Utilities
{
    public static class Config
    {
        public static int Port => 8888;
        public static string WordFilesPath =>
      Path.Combine(Directory.GetCurrentDirectory(), "Models", "Categories");
        public static string ResultsPath => "Data/Results/game_results.txt";
    }
}