using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is version control system. You have two modes to choose:" +
                "\nEnter 1 for LOG mode." +
                "\nEnter 2 for BACKUP mode.\n");
            Console.Write("Choose mode of program:");

            while (true)
            {
                string modeChoice = Console.ReadLine();
                if (modeChoice == "1")
                {
                    Console.WriteLine();
                    Logger.LoggerRun();
                    break;
                }
                if (modeChoice == "2")
                {
                    Console.WriteLine();
                    Watcher.BackUpRun();
                    break;
                }
                else
                {
                    Console.WriteLine("\nWrong input. Try again.");
                }
            }


            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
