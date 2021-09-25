using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System Management");
            AddressBook1 addressBook = new AddressBook1();
            addressBook.CreatContactDetails();
            addressBook.Display();
            Console.ReadLine();
        }

    }

}