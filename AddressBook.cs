using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookSystem
{
    class AddressBook
    {
        List<Contacts> addressBook = new List<Contacts>();
        Dictionary<string, List<Contacts>> dictionary = new Dictionary<string, List<Contacts>>();
        public List<Contacts> contacts;
        public List<Contacts> searchContacts = new List<Contacts>();
        public List<Contacts> viewContacts = new List<Contacts>();
        //address book dictioanry to store values
        public  Dictionary<string, List<Contacts>> addressBookDictionary = new Dictionary<string, List<Contacts>>();
        public void AddMember()
        {
            string addressBookName;
            contacts = new List<Contacts>();
            while (true)
            {
                Console.WriteLine("Enter The Name of the Address Book");
                addressBookName = Console.ReadLine();
                //Checking uniqueness of address books
                if (addressBookDictionary.Count > 0)
                {
                    if (addressBookDictionary.ContainsKey(addressBookName))
                    {
                        Console.WriteLine("This name of address book already exists");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

            }

            Console.Write("Enter Number of contacts you want to add:");
            int numOfContacts = Convert.ToInt32(Console.ReadLine());
            while (numOfContacts > 0)
            {
                //object for person class
                Contacts contact = new Contacts();
                while (true)
                {
                    Console.Write("Enter First Name: ");
                    string FirstName = Console.ReadLine();
                    if (contacts.Count > 0)
                    {
                        var x = contacts.Find(x => x.FirstName.Equals(FirstName));
                        if (x != null)
                        {
                            Console.WriteLine("Your name  already exists");
                        }
                        else
                        {
                            contact.FirstName = FirstName;
                            break;
                        }
                    }
                    else
                    {
                        contact.FirstName = FirstName;
                        break;
                    }
                }
                Console.Write("Enter Last Name: ");
                contact.LastName = Console.ReadLine();
                Console.Write("Enter Address: ");
                contact.Address = Console.ReadLine();
                Console.Write("Enter City: ");
                contact.City= Console.ReadLine();
                Console.Write("Enter State: ");
                contact.State = Console.ReadLine();
               
                Console.Write("Enter Zip Code: ");
                contact.Zip = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter phone Number: ");
                contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter EMail: ");
                contact.Email = Console.ReadLine();
                contacts.Add(contact);
                numOfContacts--;
            }
            //adding into address book dictionary
            addressBookDictionary.Add(addressBookName, contacts);
            Console.WriteLine("**************Successfully Added****************");
        }

        //method for view Contacts
        public void ViewContacts()
        {
            if (addressBookDictionary.Count > 0)
            {
                //printing the values in address book
                foreach (KeyValuePair<string, List<Contacts>> dict in addressBookDictionary)
                {
                    Console.WriteLine($"******************{dict.Key}*********************");
                    foreach (var addressBook in dict.Value)
                    {
                        PrintValues(addressBook);
                        Console.WriteLine("*******************************************************");
                    }
                }
            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }

        }

        //Printing values
        public void PrintValues(Contacts x)
        {
            Console.WriteLine($"First Name : {x.FirstName}");
            Console.WriteLine($"Last Name : {x.LastName}");
            Console.WriteLine($"Address : {x.Address}");
            Console.WriteLine($"City : {x.City}");
            Console.WriteLine($"State : {x.State}");
            Console.WriteLine($"Zip Code: {x.Zip}");
            Console.WriteLine($"Phone Number: {x.PhoneNumber}");
            Console.WriteLine($"Email: {x.Email}");
        }

        //method for editing details
        public void EditDetails()
        {
            int f;//flag variable
            if (contacts.Count > 0)
            {
                Console.Write("Enter name of a person you want to edit: ");
                string editName = Console.ReadLine();

                foreach (var x in contacts)
                {
                    if (editName.ToLower() == x.FirstName.ToLower())
                    {
                        while (true)
                        {
                            f = 0;
                            Console.WriteLine("1.First name \n2.Last name  \n3.Address \n4.City  \n5.State \n6.ZipCode " +
                                "\n7.Phone Number \n8.email  \n9.Exit");
                            Console.WriteLine("Enter Option You want to edit");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name");
                                    x.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    x.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    x.Address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New City");
                                    x.City = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter New State");
                                    x.State = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter New Zip Code");
                                    x.Zip = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 7:
                                    Console.WriteLine("Enter new Phone Number");
                                    x.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 8:
                                    Console.WriteLine("Enter New EMail");
                                    x.Email = Console.ReadLine();
                                  
                                    break;
                                case 9:
                                    // to exit from main method
                                    Console.WriteLine("Quit");
                                    f = 1;
                                    break;
                            }
                            if (f == 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entered name is not in Contact list");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }

        //method for deleting conatcts
        public void DeleteDetails()
        {
            int f = 0;
            if (contacts.Count > 0)
            {
                Console.Write("Enter name of a person you want to Delete: ");
                string deleteName = Console.ReadLine();

                foreach (var x in contacts)
                {
                    if (deleteName.ToLower() == x.FirstName.ToLower())
                    {
                        //removing from list
                        Console.WriteLine("***************DELETED****************");
                        Console.WriteLine($"You have deleted {x.FirstName} contact");
                        contacts.Remove(x);
                        f = 1;
                        break;
                    }
                }
                if (f == 0)
                {
                    Console.WriteLine("The name you have entered not in the address book");
                }

            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }
        public void SearchDetails()
        {
            string personName;
            Console.WriteLine("1. Search by city name\n2.Search By state name\nEnter your option:");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter the name of city in which you want to search:");
                    string cityName = Console.ReadLine();
                    Console.WriteLine("Enter the name of person you want to search:");
                    personName = Console.ReadLine();
                    SearchByCityName(cityName, personName);
                    break;
                case 2:
                    Console.WriteLine("Enter the state of city in which you want to search:");
                    string stateName = Console.ReadLine();
                    Console.WriteLine("Enter the name of person you want to search:");
                    personName = Console.ReadLine();
                    SearchByStateName(stateName, personName);
                    break;
                default:
                    return;

            }

        }

        public void SearchByCityName(string cityName, string personName)
        {
            if (addressBookDictionary.Count > 0)
            {

                foreach (KeyValuePair<string, List<Contacts>> dict in addressBookDictionary)
                {
                    searchContacts = dict.Value.FindAll(x => x.FirstName.Equals(personName) && x.State.Equals(cityName));


                }
                if (searchContacts.Count > 0)
                {
                    foreach (var x in searchContacts)
                    {
                        PrintValues(x);
                    }
                }
                else
                {
                    Console.WriteLine("Person not found");
                }
            }
            else
            {
                Console.WriteLine("Adress book is empty");
            }
        }
        public void SearchByStateName(string stateName, string personName)
        {
            if (addressBookDictionary.Count > 0)
            {

                foreach (KeyValuePair<string, List<Contacts>> dict in addressBookDictionary)
                {
                    searchContacts = dict.Value.FindAll(x => x.FirstName.Equals(personName) && x.State.Equals(stateName));

                }
                if (searchContacts.Count > 0)
                {
                    foreach (var x in searchContacts)
                    {
                        PrintValues(x);
                    }
                }
                else
                {
                    Console.WriteLine("Person not found");
                }
            }
            else
            {
                Console.WriteLine("Adress book is empty");
            }

        }
        public void ViewDetailsByStateOrCity()
        {

            Console.WriteLine("1. View by city name\n2.View By state name\nEnter your option:");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter the name of city in which you want to view:");
                    string cityName = Console.ReadLine();
                    ViewByCityName(cityName);
                    break;
                case 2:
                    Console.WriteLine("Enter the state of city in which you want to view:");
                    string stateName = Console.ReadLine();
                    ViewByStateName(stateName);
                    break;
                default:
                    return;

            }

        }

        public void ViewByCityName(string cityName)
        {
            if (addressBookDictionary.Count > 0)
            {

                foreach (KeyValuePair<string, List<Contacts>> dict in addressBookDictionary)
                {
                    viewContacts = dict.Value.FindAll(x => x.State.Equals(cityName));
                }
                if (searchContacts.Count > 0)
                {
                    foreach (var x in searchContacts)
                    {
                        PrintValues(x);
                    }
                }
                else
                {
                    Console.WriteLine("No Persons found");
                }
            }
            else
            {
                Console.WriteLine("Adress book is empty");
            }
        }
        public void ViewByStateName(string stateName)
        {
            if (addressBookDictionary.Count > 0)
            {

                foreach (KeyValuePair<string, List<Contacts>> dict in addressBookDictionary)
                {
                    viewContacts = dict.Value.FindAll(x => x.State.Equals(stateName));
                }
                if (searchContacts.Count > 0)
                {
                    foreach (var x in searchContacts)
                    {
                        PrintValues(x);
                    }
                }
                else
                {
                    Console.WriteLine("No Persons found");
                }
            }
            else
            {
                Console.WriteLine("Adress book is empty");
            }
        }
        public void CountByStateOrCity()
        {
            Console.WriteLine("1.Count by city name\n2.Count By state name\nEnter your option:");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter the name of city in which you want to count persons:");
                    string cityName = Console.ReadLine();
                    ViewByCityName(cityName);
                    break;
                case 2:
                    Console.WriteLine("Enter the name of state in which you want to count persons:");
                    string stateName = Console.ReadLine();
                    ViewByStateName(stateName);
                    break;
                default:
                    return;
            }
        }
        public void SortEntriesAlphabetically()
        {
            Console.Write("Enter the name of address book you want to sort: ");
            string addressBookName = Console.ReadLine();


            if (addressBookDictionary.ContainsKey(addressBookName))
            {
                addressBookDictionary[addressBookName].Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
                ViewContacts();
            }
            else
            {
                Console.WriteLine("This address book doesn't exists ");
            }
        }
        public void SortByCityStateZip()
        {
            Console.Write("Enter the name of address book you want to sort: ");
            string addressBookName = Console.ReadLine();
            Console.WriteLine("\nNow enter \n1. To sort by cities \n2. To sort by State \n3. To sort by Zip-Code");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (addressBookDictionary.ContainsKey(addressBookName))
            {
                switch (choice)
                {
                    case 1:
                        addressBookDictionary[addressBookName].Sort((x, y) => x.City.CompareTo(y.City));
                        break;

                    case 2:
                        addressBookDictionary[addressBookName].Sort((x, y) => x.State.CompareTo(y.State));
                        break;

                    case 3:
                        addressBookDictionary[addressBookName].Sort((x, y) => x.Zip.CompareTo(y.Zip));
                        break;

                    default:
                        Console.WriteLine("Please enter valid input.");
                        break;
                }

                ViewContacts();
            }
            else
            {
                Console.WriteLine("This address book doesn't exists");
            }
        }
    }
}