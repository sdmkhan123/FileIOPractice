using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIOPractice
{
    public class StreamReaderStreamWriter
    {
        public static string path = @"F:\DotNetClass\FileIOPractice\PracticeFile.txt";
        public static void fileExist()
        {
        }
        public static void streamReader()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void sreamWriter()
        {
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("\nHi this is a newly appended text in file");
                sr.Close();
                Console.WriteLine(File.ReadAllLines(path));
                ReadAndWriteInFile.readAllLine();
            }
        }
    }
}
