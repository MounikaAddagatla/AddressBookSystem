using System;

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
                Console.WriteLine("\n1 - Create a new contact  \n2 -Display all contacts  \n3 -Edit contact \n4 -Delete contact  \n5 -Add New Contact \n6 -Quit ");
               
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
                        addressBook.EditContact(firstName);
                        break;
                    case 4:
                        // Delete a Contact by using first name // 
                        Console.WriteLine("Enter the firstName which you want to delete");
                        firstName = Console.ReadLine();
                        addressBook.DeleteContact(firstName);
                        break;
                        // Add new Contact using Contact class //
                    case 5:
                        Console.WriteLine("Enter the New Contact Details");
                        addressBook.AddNewContact();
                        break;
                        /// for Quit //
                    case 6:
                        flag = false;
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