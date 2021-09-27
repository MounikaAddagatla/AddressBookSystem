using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        List<Contacts> addressBook = new List<Contacts>();
        private string firstName;

        public void CreateANewContact()
        {
            Contacts contact = new Contacts();
            Console.WriteLine(" Enter Your First name ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine(" Enter your Last name  ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine(" Enter Your Address  ");
            contact.Address = Console.ReadLine();
            Console.WriteLine(" Enter Your city ");
            contact.City = Console.ReadLine();
            Console.WriteLine(" Enter your State");
            contact.State = Console.ReadLine();
            Console.WriteLine(" Enter Your Zip ");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Your Phone number ");
            contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Email id ");
            contact.Email = Console.ReadLine();
            addressBook.Add(contact);
        }
        /// <summary>
        /// /Display the cantact list in address book//
        /// </summary>
      public void Display()
        {
            Console.WriteLine( " Contact Details in List ");
            foreach(var data in addressBook)
            {
                Console.WriteLine(data.FirstName + " " + data.LastName + "" + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
            }
        }
        ///Edit contact details in address book//
        public bool EditContact(string firstName)
        {
            foreach (var contact in addressBook)
            {

                if (contact.FirstName == firstName)
                {             
                    Console.WriteLine("Enter new name: ");
                    contact.FirstName = Console.ReadLine();
                    Console.WriteLine("Address updated for {0}", firstName);
                    return true;
                }
               
            }
            return false;
           
        }
        ////
        ///delete contact details using first name//
        public bool DeleteContact(string firstName)
        {
            foreach (Contacts contact in addressBook)
            {
                if (contact.FirstName == firstName)
                {
                    addressBook.Remove(contact);
                    return true;
                }
            }
            return false;
        }
        public bool AddNewContact()
        {
           Contacts contact1 = new Contacts();

            if (contact1 == null)
            {
                addressBook.Add(contact1);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
