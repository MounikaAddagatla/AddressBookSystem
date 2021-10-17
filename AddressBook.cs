using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookSystem
{
    class AddressBook
    {
        List<Contacts> addressBook = new List<Contacts>();
        Dictionary<string, List<Contacts>> dictionary = new Dictionary<string, List<Contacts>>();
      

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
        public void EditContact()
        {
            Console.WriteLine("to edit contact list enter contact firstname");
            string name = Console.ReadLine().ToLower();
            foreach (var data in addressBook)
            {
                if (addressBook.Contains(data))
                {
                    if (data.FirstName.Equals(name))
                    {
                        Console.WriteLine("To edit contacts enter 1.LastName\n 2.Address\n 3.City\n 4.State\n 5.Zip\n 6.PhoneNumber\n 7.Email\n");
                        int options = Convert.ToInt32(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                string lastname = Console.ReadLine();
                                break;
                            case 2:
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;
                            case 3:
                                string city = Console.ReadLine();
                                data.City = city;
                                break;
                            case 4:
                                string state = Console.ReadLine();
                                data.State = state;
                                break;
                            case 5:
                                int Zip = Convert.ToInt32(Console.ReadLine());
                                data.Zip = Zip;
                                break;
                            case 6:
                                int number = Convert.ToInt32(Console.ReadLine());
                                data.PhoneNumber = number;
                                break;
                            case 7:
                                string email = Console.ReadLine();
                                data.Email = email;
                                break;
                            default:
                                Console.WriteLine("choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("name doesnt matches");
                    }
                }
                Display();
            }
           

        }
        ////
        ///delete contact details using first name//
        public void DeleteContact()
        {
            Contacts contact = new Contacts();
            string name = Console.ReadLine();
            foreach ( var data in addressBook)
            {
                if (data.Firstname.Equals(name))
                {
                    addressBook.Remove(contact);
                    Console.WriteLine("Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("given name contact does not exists");
                }
            }
            Display();
          
           
        }
        public void AddMultiContacts(int n)
        {
            while (n > 0)
            {
                CreateANewContact();
                n--;                            ///n = no for contacts to add 
            }
        }
        public void AddressBookInDictionary()
        {
            Console.WriteLine("Enter the name of Dictionary");
            string name = Console.ReadLine();
            foreach (var contacts in dictionary)
            {
                if (contacts.Key.Contains(name))
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine(data.FirstName + " " + data.LastName + "" + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                    }
                }
                
            }
        }
        // check whether the same person exist
        public bool Check(string fname)
        {
            int flag = 0;
            foreach(Contacts cantact in addressBook)
            {
                if (cantact.FirstName.Equals(fname))
                //check first name and enter details are equl or not
                {
                    flag = 1;
                    break;
                }
            }
            if(flag == 1)
            {
                return true;
            }
            return false;
        }
       


    }
}
