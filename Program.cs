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
                Console.WriteLine("\n1 - Create a new contact  \n2 -Display all contacts  \n3 -Edit contact  \n4 - Delete contact ");
               
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        addressBook.CreateANewContact();
                        break;
                    case 2:
                        addressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the phone number for which you want to edit the details");
                        int phoneNumber = (int)Convert.ToInt64(Console.ReadLine());
                        addressBook.EditAContact(phoneNumber);
                        break;
                    case 4:
                        Console.WriteLine("Enter the phone number which you want to delete");
                        int phoneNumber1 = (int)Convert.ToInt32(Console.ReadLine());
                        addressBook.DeleteContact(phoneNumber1);
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