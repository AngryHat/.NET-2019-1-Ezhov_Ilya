using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reads two lines of text and multiplies by 2 all the characters from second text in the first.\n");
            Console.Write("Please enter the text that will be modified: ");
            string inputText = Console.ReadLine();
            Console.Write("Please enter the text that contains chars to multiple: ");
            string searchPhrase = Console.ReadLine();

            searchPhrase = PreveentDunpicatedChars(searchPhrase);
            string result = RedoubleCharsByPhrase(inputText, searchPhrase);
            Console.WriteLine($"\nThe result of the program is:\n\n{result}");
            
            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }

        static string RedoubleCharsByPhrase(string input, string phrase)
        {
            string modifiedString = input;
            for (int i = 0; i < phrase.Length; i++)
            {
                int entering = modifiedString.IndexOf(phrase[i]);
                while (entering != -1)
                {
                    //Console.WriteLine($"'{phrase[i]}' found at index {entering}.");
                    modifiedString = modifiedString.Insert(entering, Convert.ToString(phrase[i]));
                    entering += 2;
                    entering = modifiedString.IndexOf(phrase[i], entering);
                }
            }
            return modifiedString;
        }
        static string PreveentDunpicatedChars(string input)
        {
            string modifiedPhrase = input;
            for (int i = 0; i < modifiedPhrase.Length; i++)
            {
                for (int j = i + 1; j < modifiedPhrase.Length; j++)
                {
                    if (modifiedPhrase[i] == modifiedPhrase[j])
                    {
                        modifiedPhrase = input.Remove(j, 1);
                    }
                }
            }
            return modifiedPhrase;
        }
    }
}
