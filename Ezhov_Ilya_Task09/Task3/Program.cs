using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "there are wild and domestic animals. wild animals live in the forest or in the zoo." +
                " some animals are dangerous. a fox, a wolf, a bear, a hare, a tiger, an elephant are wild animals." +
                " domestic animals live at home or at the farm. they are dogs, cats, rabbits, cows, horses, parrots." +
                " animals that we have at home are called pets.";

            Dictionary<string, int> englishWords = new Dictionary<string, int>();

            char[] separators = new char[] {' ', '.', ',', '!', '?'};
            string[] textArray = text.Split(separators);

            foreach (string word in textArray)
            {
                string wordIgnoreCase = word.ToLower();
                if (englishWords.ContainsKey(wordIgnoreCase))
                {
                    englishWords[wordIgnoreCase] += 1;
                }
                else
                {
                    englishWords.Add(wordIgnoreCase, 1);
                }
            }

            foreach (KeyValuePair<string, int> keyValue in englishWords)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }
    }
}
