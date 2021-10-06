using System;

namespace FileIOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================================================\n");
            Console.WriteLine("-------------------Welcome to File IO practice problem-------------------");
            Console.WriteLine("\n===============================================================================\n");
            Console.WriteLine("\n*************************************************************************************\n");
            Console.WriteLine("-------------------Welcome to check file exist or Not-------------------");
            ReadAndWriteInFile.fileExist();
            Console.WriteLine("\n*************************************************************************************\n");
            Console.WriteLine("-------------------Welcome to Read All Line by Line(Array of String)-------------------");
            ReadAndWriteInFile.readAllLine();
            Console.WriteLine("\n*************************************************************************************\n");
            Console.WriteLine("-------------------Welcome to Read All as Text (Single String)-------------------");
            ReadAndWriteInFile.readAllText();
            Console.WriteLine("\n*************************************************************************************\n");
            Console.WriteLine("-------------------Welcome to Copy file data-------------------");
            ReadAndWriteInFile.copyFile();
            Console.WriteLine("\n*************************************************************************************\n");
            Console.WriteLine("-------------------Welcome to Stream reader-------------------");
            StreamReaderStreamWriter.streamReader();
            Console.WriteLine("\n*************************************************************************************\n");
            Console.WriteLine("-------------------Welcome to Stream writer-------------------");
            StreamReaderStreamWriter.sreamWriter();
            Console.WriteLine("\n*************************************************************************************\n");
        }
    }
}