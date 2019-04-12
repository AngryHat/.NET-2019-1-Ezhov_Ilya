using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Task2
{
    public class Logger
    {
        private static string _watchingFolderName = "\\VCS";
        public static string _backupFolderName = "\\_backup";
        public static string WatchingFolderPath = Environment.CurrentDirectory + _watchingFolderName;
        public static string BackupFolderPath = Environment.CurrentDirectory + _watchingFolderName + _backupFolderName;
        private static string _loggerFileName = WatchingFolderPath + @"\log.txt";

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

        public void LoggerRun()
        {
            string startMessage = ("\n\n" + DateTime.Now + " logger is running.");
            log.Add(startMessage);
            Console.WriteLine(startMessage);

            Watcher.WatcherRun();
            LoggerWrite();
        }

        // writing to log from List<string> log
        public void LoggerWrite()
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

    public class Watcher
    {
        public static void WatcherRun()
        {
            CheckAndCreateDirectories();

            using (FileSystemWatcher fileWatcher = new FileSystemWatcher())
            {
                fileWatcher.Path = Logger.WatchingFolderPath;
                fileWatcher.IncludeSubdirectories = true;

                fileWatcher.NotifyFilter = NotifyFilters.LastWrite;

                fileWatcher.Filter = "*.txt";

                fileWatcher.Changed += OnChanged;

                fileWatcher.EnableRaisingEvents = true;

                Console.WriteLine("\n!!ATTENTION!! Press 'q' and then Enter key to turn off the logger correctly.\n");
                while (Console.Read() != 'q') ;
            }
        }

        private static void OnChanged(object source, FileSystemEventArgs watchingFileInfo)
        {
            string message = ($"File: {watchingFileInfo.FullPath} changed.");
            Logger.log.Add(message);
            Console.WriteLine(message);

            string backupFileName = Logger.BackupFolderPath + @"\" + watchingFileInfo.Name + Logger.CurrentTime;

            if (!File.Exists(backupFileName))
            {
                File.Copy(watchingFileInfo.FullPath, backupFileName);
                message = ($"File: {watchingFileInfo.Name + Logger.CurrentTime} has been created in {Logger._backupFolderName} folder.");
                Logger.log.Add(message);
                Console.WriteLine(message);
            }
        }

        private static void CheckAndCreateDirectories()
        {
            var innerDirectories = Directory.GetDirectories(Logger.WatchingFolderPath);
            foreach (var dir in innerDirectories)
            {
                string missingDir = dir.Remove(0, Logger.WatchingFolderPath.Length);

                if (!Directory.Exists(Logger.BackupFolderPath + missingDir) && missingDir != Logger._backupFolderName)
                {
                    Directory.CreateDirectory(Logger.BackupFolderPath + missingDir);
                }
            }
        }

    }

    class BackUpper
    {
        public static void BackUpperRun()
        {
            //read line
            Console.WriteLine("You entered backup mode. To backup file please enter the name of file and date and time of version you want to restore.");
            RestoreFile();
        }

        public static void RestoreFile()
        {
            // move the filename getter out from these method
            string backupRequest = "\\File.txt 2019-4-12 19-1-38";
            //string backupPath = Logger.BackupFolderPath + backupRequest;
            string backupPath = Logger.BackupFolderPath + backupRequest;
            if (File.Exists(backupPath))
            {
                int n = backupRequest.IndexOf(" 2019-4-12 19-1-38");
                string originalFileName = backupRequest.Remove(n, " 2019-4-12 19-1-38".Length);
                File.Delete(Logger.WatchingFolderPath + originalFileName);
                File.Copy(backupPath, Logger.WatchingFolderPath + originalFileName);
                Console.WriteLine("File replaced");
            }
            else
            {
                Console.WriteLine("File not extist.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logger - 1; Backupper - 2");
            BackUpper.RestoreFile();

            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
