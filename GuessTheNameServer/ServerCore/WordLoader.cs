using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNameServer.Utilities;

namespace GuessTheNameServer.ServerCore
{
    public static class WordLoader
    {

        public static async Task<string> LoadRandomWord(string category)
        {
            try
            {
                var filePath = Path.Combine("Models", "Categories", $"{category}.txt");
                if (!File.Exists(filePath))
                    throw new FileNotFoundException($"Category file not found: {filePath}");

                var words = await File.ReadAllLinesAsync(filePath);

                if (words.Length == 0)
                    throw new InvalidOperationException($"No words found in category: {category}");

                var random = new Random();
                return words[random.Next(words.Length)];
            }
            catch (Exception ex)
            {
                Logger.Log($"Error loading word for category '{category}': {ex.Message}");
                return "default";
            }
        }
    }
}
