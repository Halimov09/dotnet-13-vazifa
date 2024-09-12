using System;
using System.IO;
using System.Linq;

namespace CONTACT.classes
{
    public class Addcontact
    {
        public string Name {get; set;}
        public long Number {get; set;}

        public  Addcontact (string name, long number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Name}, {Number}";
        }
    }
}