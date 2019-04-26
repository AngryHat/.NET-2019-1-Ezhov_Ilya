using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reads engilsh text and separate it to sigle words. " +
                "\nThen program count repeating words in text and dysplay result.\n");

            string text = "there are wild and domestic animals. wild animals live in the forest or in the zoo.\n" +
                "some animals are dangerous. a fox, a wolf, a bear, a hare, a tiger, an elephant are wild animals.\n" +
                "domestic animals live at home or at the farm. they are dogs, cats, rabbits, cows, horses, parrots.\n" +
                "animals that we have at home are called pets.";
            Console.WriteLine($"Original text is:\n\n{text}\n\n");

            // With Regex
            Dictionary<string, int> englishWordsReg = new Dictionary<string, int>();
            Regex regex = new Regex(@"\w+");
            MatchCollection words = regex.Matches(text);
            foreach (Match match in words)
            {
                string word = match.Value;
                if (englishWordsReg.ContainsKey(word.ToLower()))
                {
                    englishWordsReg[word.ToLower()] += 1;
                }
                else
                {
                    englishWordsReg.Add(word.ToLower(), 1);
                }
            }

            // Without Regex
            //Dictionary<string, int> englishWords = new Dictionary<string, int>();

            //char[] separators = new char[] {' ', '.', ',', '!', '?'};
            //string[] textArray = text.Split(separators);

            //foreach (string word in textArray)
            //{
            //    string wordIgnoreCase = word.ToLower();
            //    if (englishWords.ContainsKey(wordIgnoreCase))
            //    {
            //        englishWords[wordIgnoreCase] += 1;
            //    }
            //    else
            //    {
            //        englishWords.Add(wordIgnoreCase, 1);
            //    }
            //}
            
            foreach (KeyValuePair<string, int> keyValue in englishWordsReg)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
