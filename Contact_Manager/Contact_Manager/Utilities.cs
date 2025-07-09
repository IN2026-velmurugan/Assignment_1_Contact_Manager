//class file with methods for the services for verification
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class Utilities
    {
        public bool IsValidName(string name, List<ContactsInfo> list)
        {
            if (new Services().FindByName(name, list) == -1) return true;
            Console.WriteLine();
            Console.WriteLine("Name already Exists");
            return false;
        }
        public bool IsValidUpdateChoice(string choice)
        {
            if (choice == "E" || choice == "N" || choice == "P" || choice == "NT" || choice == "M") return true;
            return false;
        }

        public bool IsValidSearchChoice(string choice)
        {
            if (choice == "E" || choice == "N" || choice == "P" || choice == "A") return true;
            Console.WriteLine();
            Console.WriteLine("NOT A VALID CHOICE");
            Console.WriteLine();
            return false;
        }
    }
}
