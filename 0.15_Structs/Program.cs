using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry Nathan = new AddressBookEntry()
            {
                Address = "1708 East 66th Street",
                City = "Indianapolis",
                State = "IN",
                Zip = "46220",
                FirstName = "Nathan",
                LastName = "Randall",
                Age = "39",
            };
            AddressBookEntry Dawn = new AddressBookEntry()
            {
                Address = "1708 East 66th Street",
                City = "Indianapolis",
                State = "IN",
                Zip = "46220",
                FirstName = "Dawn",
                LastName = "Neumann",
                Age = "44",
            };
            AddressBookEntry Lilly = new AddressBookEntry()
            {
                Address = "1708 East 66th Street",
                City = "Indianapolis",
                State = "IN",
                Zip = "46220",
                FirstName = "Lilly",
                LastName = "The Cat",
                Age = "8",
            };
            AddressBookEntry MacGreggor = new AddressBookEntry()
            {
                Address = "1708 East 66th Street",
                City = "Indianapolis",
                State = "IN",
                Zip = "46220",
                FirstName = "MacGreggor",
                LastName = "The Dog",
                Age = "14",
            };


            Console.WriteLine(Lilly.GetInfo());
            Console.WriteLine(Nathan.GetAddress());
            Console.ReadLine();
        }
        struct AddressBookEntry
        {
            public string FirstName;
            public string LastName;
            public string Age;
            public string Address;
            public string City;
            public string State;
            public string Zip;

            public string GetAddress()
            {
                return $"Address: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}";
            }
            public string GetInfo()
            {
                return $"Name: {FirstName}\nLast Name: {LastName}\nAge: {Age}";
            }
        }
    }
}
