using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Task3
{
    class Program
    {
        public static double doubleNum = -1.01;
        public static int intNum = 1000000000;
        public static double valNum = 299.99;
        public static DateTime date = new DateTime(2019, 03, 14, 21, 14, 55);

        static void Main(string[] args)
        {
            CultureInfo ruCult = new CultureInfo("ru-RU");
            CultureInfo enCult = new CultureInfo("en-US");
            CultureInfo invCult = CultureInfo.InvariantCulture;
            Console.WriteLine("This program shows differences between cultures (CultureInfo).\n");
            ShowCultInfo(ruCult, enCult);
            ShowCultInfo(enCult, invCult);
            ShowCultInfo(ruCult, invCult);

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }

        static void ShowCultInfo(CultureInfo cult1, CultureInfo cult2)
        {
            Console.WriteLine($"\n\nDifference between {cult1.EnglishName} and {cult2.EnglishName}:\n\n");
            Thread.CurrentThread.CurrentCulture = cult1;
            ShowSamples();
            Thread.CurrentThread.CurrentCulture = cult2;
            ShowSamples();
        }
        static public void ShowSamples()
        {
            Console.WriteLine(CultureInfo.CurrentCulture.EnglishName);
            Console.WriteLine($"\nDouble number: {doubleNum}");
            Console.WriteLine($"Date/Time: {date}");
            Console.WriteLine($"Big int number: {intNum:N0}");
            Console.WriteLine($"Currency: {valNum:C2}\n");
        }

    }
}
