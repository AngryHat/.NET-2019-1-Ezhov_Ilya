using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reads .txt file (with numbers on each string in it) " +
                "\nand replace each number with the square of that number.\n");

            string sourseFileName = "disposable_task_file.txt";
            Console.WriteLine($"Processing with file {sourseFileName}.");

            int sourse;
            List<int> result = new List<int>();

            using (StreamReader streamReader = new StreamReader(sourseFileName))
            {
                while (!streamReader.EndOfStream)
                {
                    sourse = int.Parse(streamReader.ReadLine());
                    result.Add(sourse * sourse);
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(sourseFileName, false))
            {
                foreach (var line in result)
                {
                    streamWriter.WriteLine(line);
                }
            }
            Console.WriteLine("File updated.");

            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }

        // Same program with replacing files

        //static void Main(string[] args)
        //{
        //    string sourseFileName = "disposable_task_file.txt";
        //    string resultFileName = "result.txt";
        //    //string fullPath = (Environment.CurrentDirectory + "\\" + sourseFileName);

        //    int sourse;
        //    int result;

        //    StreamWriter streamWriter = new StreamWriter(resultFileName, false);
        //    using (StreamReader streamReader = new StreamReader(sourseFileName))
        //    {

        //        while (!streamReader.EndOfStream)
        //        {
        //            sourse = int.Parse(streamReader.ReadLine());
        //            result = sourse * sourse;

        //            streamWriter.WriteLine(result);
        //        }
        //        streamWriter.Close();
        //    }

        //    // Option 1
        //    //File.Replace(resultFileName, sourseFileName, "_backup");
        //    //File.Delete("_backup");

        //    // Option 2
        //    File.Delete(sourseFileName);
        //    File.Move(resultFileName, sourseFileName);

        //    Console.WriteLine("End of program. Press any key.");
        //    Console.ReadKey();
        //}
    }
}
