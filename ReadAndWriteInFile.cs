using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIOPractice
{
    public class ReadAndWriteInFile
    {
        public static string path = @"F:\DotNetClass\FileIOPractice\PracticeFile.txt";
        public static void fileExist()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Given Text file is exist");
            }
        }
        public static void readAllLine()
        {
            string[] lines;
            lines = File.ReadAllLines(path);
            foreach(string str in lines)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(lines[1]);
        }
        public static void readAllText()
        {
            string str;
            str = File.ReadAllText(path);
            Console.WriteLine(str);
        }
        public static void copyFile()
        {
            string copyPath = @"F:\DotNetClass\FileIOPractice\PracticeFileCopy.txt";
            File.Copy(path, copyPath);
            string str;
            Console.WriteLine("Data in copy file:-");
            str = File.ReadAllText(copyPath);
            Console.WriteLine(str);
            Console.WriteLine("Before delete CopyFile, the path is:-\n" + copyPath);
            deleteFile(copyPath);
        }
        public static void deleteFile(string copyPath)
        {
            File.Delete(copyPath);
            Console.WriteLine("File is deleted successfully");
            Console.WriteLine("After delete CopyFile, the path is:-\n" + copyPath);
        }
    }
}
