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
            bool value = false;
            while (!value)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("1.Add member to Contact list \n2.View Members in Contact List \n3.Edit members Contacts list\n4.Delete members Contacts list\n" +
                    "5.Search by name \n6.Count by state or city\n7 SortByAlphabet");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        addressBook.AddMember();
                        break;
                    case 2:
                        addressBook.ViewContacts();
                        break;
                    case 3:
                        addressBook.EditDetails();
                        break;
                    case 4:
                        addressBook.DeleteDetails();
                        break;
                    case 5:
                        addressBook.SearchDetails();
                        break;
                    case 6:
                        addressBook.CountByStateOrCity();
                        break;
                    case 7:
                        addressBook.SortEntriesAlphabetically();
                        break;
                    default:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        break;

                }
            }
        
            Console.ReadLine();
        }

    }

}