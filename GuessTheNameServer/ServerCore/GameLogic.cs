using System.IO;
using System.Text;

namespace GuessTheNameServer.ServerCore
{
    public  class GameLogic
    {
        //public static string GetRandomWord(string category)
        //{
        //    var path = Path.Combine("Models", "Categories", $"{category}.txt");
        //    var words = File.ReadAllLines(path);
        //    return words[new Random().Next(words.Length)].ToUpper();
        //}

        private string _word;

        public GameLogic(string word)
        {
            _word = word; 
        }
        public (bool isCoreect, bool isFinished) CheckLetter(List<char> word, char letter)
        {
            bool correct = false;
            for (int i = 0; i < _word.Length; i++)
            {
                if (letter == _word[i] && word[i] != '_')
                {
                    word[i] = letter;
                    correct = true;
                }
            }
            return (correct, !word.Contains('_'));
        }
    }
}