using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        List<Contacts> addressBook = new List<Contacts>();
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
      public void Display()
        {
            Console.WriteLine( " Contact Details in List ");
            foreach(var data in addressBook)
            {
                Console.WriteLine(data.FirstName + " " + data.LastName + "" + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
            }
        }
       
       
    }
}
