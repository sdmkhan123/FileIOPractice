using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace FileIOPractice
{
    public class SerializationAndDeserialization
    {
        const string binaryfilePath = @"F:\DotNetClass\FileIOPractice\binaryFile.txt";
        const string XmlfilePath = @"F:\DotNetClass\FileIOPractice\XmlFile.txt";
        public static void binarySerialization()
        {
            Contact con = new Contact();
            FileStream fileStream = new FileStream(binaryfilePath, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, con);
            fileStream.Close();
        }
        public static void binaryDeserialization()
        {
            FileStream fileStream = new FileStream(binaryfilePath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Contact con = (Contact) binaryFormatter.Deserialize(fileStream);
            Console.WriteLine("Name : " + con.name);
            Console.WriteLine("Name : " + con.addr);
            Console.WriteLine("Name : " + con.age);
            fileStream.Close();
        }
        public static void xmlSerialization()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Contact));
            FileStream fileStream = new FileStream(XmlfilePath, FileMode.Create);
            Contact con = new Contact();
            xmlSerializer.Serialize(fileStream, con);
            fileStream.Close();
        }
        public static void xmlDeserialization()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Contact));
            FileStream fileStream = new FileStream(XmlfilePath, FileMode.Open);
            Contact con = (Contact)xmlSerializer.Deserialize(fileStream);
            Console.WriteLine("Name : " + con.name);
            Console.WriteLine("Name : " + con.addr);
            Console.WriteLine("Name : " + con.age);
            fileStream.Close();
        }
    }
}