using System;
using System.Collections.Generic;
using System.Text;

namespace FileIOPractice
{
    [Serializable]
    public class Contact
    {
        public string name { get; set; } = "Saddam Khan";
        public string addr { get; set; } = "Uttar Pradesh";
        public int age { get; set; } = 25;
    }
}