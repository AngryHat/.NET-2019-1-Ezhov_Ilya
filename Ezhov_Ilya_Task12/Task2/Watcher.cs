using System;
using System.IO;

namespace Task2
{
    public class Watcher
    {
        private static string _watchingFolderName = "\\VCS";
        public static string _backupFolderName = "\\_backup";
        public static string WatchingFolderPath = Environment.CurrentDirectory + _watchingFolderName;
        public static string BackupFolderPath = Environment.CurrentDirectory + _watchingFolderName + _backupFolderName;

        public static void WatcherRun()
        {
            CheckAndCreateDirectories();

            using (FileSystemWatcher fileWatcher = new FileSystemWatcher())
            {
                fileWatcher.Path = WatchingFolderPath;
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

            string backupFileName = BackupFolderPath + @"\" + watchingFileInfo.Name + Logger.CurrentTime;

            if (!File.Exists(backupFileName))
            {
                File.Copy(watchingFileInfo.FullPath, backupFileName);
                message = ($"File: {watchingFileInfo.Name + Logger.CurrentTime} has been created in {_backupFolderName} folder.");
                Logger.log.Add(message);
                Console.WriteLine(message);
            }
        }

        private static void CheckAndCreateDirectories()
        {
            var innerDirectories = Directory.GetDirectories(WatchingFolderPath);
            foreach (var dir in innerDirectories)
            {
                string missingDir = dir.Remove(0, WatchingFolderPath.Length);

                if (!Directory.Exists(BackupFolderPath + missingDir) && missingDir != _backupFolderName)
                {
                    Directory.CreateDirectory(BackupFolderPath + missingDir);
                }
            }
        }

        public static void BackUpRun()
        {
            Console.WriteLine("You entered backup mode. To backup file please enter the name of file and date and time of version you want to restore.");
            Console.WriteLine("This program is not so perfect, so you have to enter inner folder name\n" +
                "(if it was in inner folder), file name, space and date and time(include mintes and seconds)\n" +
                "to restore previous version of file.");
            RestoreFile();
        }


        public static void RestoreFile()
        {
            string backupRequest = Console.ReadLine();
            string backupPath = BackupFolderPath + "\\" + backupRequest;
            
            if (File.Exists(backupPath))
            {
                int n = backupRequest.IndexOf(" ");
                string originalFileName = backupRequest.Remove(n, backupRequest.Length - n);
                File.Delete(WatchingFolderPath + originalFileName);
                File.Copy(backupPath, WatchingFolderPath + originalFileName);
                Console.WriteLine("\nFile replaced\n");
            }
            else
            {
                Console.WriteLine("\nFile not extist.\n");
            }
            //Q? File.Delete / Copy doesn't work in while loop
        }
    }
}
