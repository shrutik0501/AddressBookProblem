using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookManagement
    {
        private Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();

        public void AddAddressBook(string addressBookName)
        {
            if (!addressBooks.ContainsKey(addressBookName))
            {
                addressBooks.Add(addressBookName, new AddressBook());
                Console.WriteLine("Address book added: " + addressBookName);
            }
            else
            {
                Console.WriteLine("Address book already exists: " + addressBookName);
            }
        }

        public void AddContact(string addressBookName, Contacts contact)
        {
            if (addressBooks.TryGetValue(addressBookName, out AddressBook addressBook))
            {
                addressBook.AddContact(contact);
                Console.WriteLine("Contact added to address book: " + addressBookName);
            }
            else
            {
                Console.WriteLine("Address book not found: " + addressBookName);
            }
        }

        public void PrintContacts(string addressBookName)
        {
            if (addressBooks.TryGetValue(addressBookName, out AddressBook addressBook))
            {
                List<Contacts> contacts = addressBook.contacts;
                foreach (Contacts contact in contacts)
                {
                    Console.WriteLine("FirstName   = " + contact.FirstName);
                    Console.WriteLine("LastName    = " + contact.LastName);
                    Console.WriteLine("Address     = " + contact.Address);
                    Console.WriteLine("City        = " + contact.City);
                    Console.WriteLine("State       = " + contact.State);
                    Console.WriteLine("Zip         = " + contact.Zip);
                    Console.WriteLine("PhoneNumber = " + contact.PhoneNumber);
                    Console.WriteLine("Email       = " + contact.Email);
                    Console.WriteLine("------------------------");
                }
            }
            else
            {
                Console.WriteLine("Address book not found: " + addressBookName);
            }
        }


        public void EditContact(string addressBookName, string firstName, string lastName)
        {
            if (addressBooks.TryGetValue(addressBookName, out AddressBook addressBook))
            {
                addressBook.EditContact(firstName, lastName);
            }
            else
            {
                Console.WriteLine("Address book not found: " + addressBookName);
            }
        }

        public void DeleteContact(string addressBookName, string firstName, string lastName)
        {
            if (addressBooks.TryGetValue(addressBookName, out AddressBook addressBook))
            {
                addressBook.DeleteContact(firstName, lastName);
            }
            else
            {
                Console.WriteLine("Address book not found: " + addressBookName);
            }
        }

        public List<Contacts> SearchByCity(string city)
        {
            List<Contacts> contacts = new List<Contacts>();

            foreach (AddressBook addressBook in addressBooks.Values)
            {
                contacts.AddRange(addressBook.GetContactsByCity(city));
            }

            return contacts;
        }

        public List<Contacts> SearchByState(string state)
        {
            List<Contacts> contacts = new List<Contacts>();

            foreach (AddressBook addressBook in addressBooks.Values)
            {
                contacts.AddRange(addressBook.GetContactsByState(state));
            }

            return contacts;
        }
        }   
    }


