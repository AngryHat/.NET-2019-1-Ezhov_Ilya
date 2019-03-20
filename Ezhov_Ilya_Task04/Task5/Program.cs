using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program replaces all HTML tags with '_' chars. \n");
            string pattern = @"<.*?>";
            //string input = @"<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами";
            Console.WriteLine("Please enter your HTML code:");
            string input = Console.ReadLine();
            string result = string.Empty;

            RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                result = input.Replace(m.Value, "_");
            }
            Console.WriteLine(result);


            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
