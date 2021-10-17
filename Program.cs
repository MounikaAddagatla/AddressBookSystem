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
            Dictionary<string, AddressBook> dictAddressBook = new Dictionary<string, AddressBook>();

            bool flag = true;
          
            while (flag)
            {

                Console.WriteLine("\n1 - Create a new contact  \n2 -Display all contacts  \n3 -Edit contact \n4 -Delete contact  \n5 -Add multiple contacts " +
                    "\n6 -addressBook in Dictonary \n7 - Check person exist or not \n8 - Search person by city/state");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        // for creating contact details//
                        addressBook.CreateANewContact();
                        break;
                    case 2:
                        // for display list of contacts//

                        addressBook.Display();
                        break;
                    case 3:
                        // for edit contact details//
                        Console.WriteLine("Enter the firstName for which you want to edit the details");
                       string firstName =Console.ReadLine();
                        addressBook.EditContact();
                        break;
                    case 4:
                        // Delete a Contact by using first name // 
                        Console.WriteLine("Enter the firstName which you want to delete");
                        firstName = Console.ReadLine();
                        addressBook.DeleteContact();
                        break;
                    /// for Quit //
                    case 5:
                        /// add multiple contacts
                        addressBook.AddMultiContacts(2);
                        addressBook.Display();
                        break;
                    case 6:
                        // adding a new addressbook//
                        addressBook.AddressBookInDictionary();
                        addressBook.Display();
                        break;
                    case 7:
                        string var = Console.ReadLine();
                        Console.WriteLine(addressBook.Check(var)); // return bool value
                        break;
                    case 8:
                        addressBook.SearchCityOrState();
                        addressBook.Display();
                        break;
                    default:
                        Console.WriteLine("enter the values in range ");
                        break;
                }
            }
            Console.ReadLine();
        }

    }

}