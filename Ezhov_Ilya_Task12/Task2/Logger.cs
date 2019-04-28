using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    public class Logger
    {
        private static string _loggerFileName = Environment.CurrentDirectory + "\\VCS" + @"\log.txt";

        public static List<string> log = new List<string>();
        public static string CurrentTime
        {
            get
            {
                DateTime _now = DateTime.Now;
                string _currentDate = $" {_now.Year}-{_now.Month}-{_now.Day} {_now.Hour}-{_now.Minute}-{_now.Second}";
                return _currentDate;
            }
        }

        public static void LoggerRun()
        {
            string startMessage = ("\n\n" + DateTime.Now + " logger is running.");
            log.Add(startMessage);
            Console.WriteLine(startMessage);

            Watcher.WatcherRun();
            LoggerWrite();
        }

        // writing to log from List<string> log
        public static void LoggerWrite()
        {
            if (!File.Exists(_loggerFileName))
            {
                File.Create(_loggerFileName);
            }
            using (StreamWriter streamWriter = new StreamWriter(_loggerFileName, true))
            {
                foreach (var line in log)
                {
                    streamWriter.WriteLine(line);
                }
            }
        }
    }
}
