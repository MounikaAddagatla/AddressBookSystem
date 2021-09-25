using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System Management");
            AddressBook addressBook = new AddressBook();
          
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1 - Create a new contact  \n2 -Display all contacts   ");
               
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        addressBook.CreateANewContact();
                        break;
                    case 2:
                        addressBook.Display();
                        break;
                   
                    default:
                        Console.WriteLine("Enter the values in range ");
                        break;
                }
            }
            Console.ReadLine();
        }

    }

}