using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;

namespace FileIOPractice
{
    public class CsvHandler
    {
        public static void csvImplement()
        {
            string importPath = @"F:\DotNetClass\FileIOPractice\utility\Addr.csv";
            string exportPath = @"F:\DotNetClass\FileIOPractice\utility\export.csv";
            using (var reader = new StreamReader(importPath))
            using (var csvimport = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var record = csvimport.GetRecords<Contact>().ToList();
                Console.WriteLine("Read the data from Addr csv file is successfully");
                foreach(Contact con in record)
                {
                    Console.Write("\t"+ con.name);
                    Console.Write("\t" + con.addr);
                    Console.Write("\t" + con.age);
                    Console.WriteLine();
                }
                Console.WriteLine("====Now writting into csv file===");
                using (var writer = new StreamWriter(exportPath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(record);
                }
            }
        }
    }
}
