namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookManagement addressBookManager = new AddressBookManagement();
            Console.WriteLine("Welcome to Address Book Management System ");

            while (true)
            {
                Console.WriteLine("\nEnter your choice:\n1. Add Address Book\n2. Add Contact\n3. Print Contacts\n4. Edit Contact\n5. Delete Contact\n6. Search Contacts By City\n7. Search Contacts By State\n8. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter address book name: ");
                        string addressBookName = Console.ReadLine();
                        addressBookManager.AddAddressBook(addressBookName);
                        break;
                    case 2:
                        Console.Write("Enter address book name: ");
                        addressBookName = Console.ReadLine();

                        Console.Write("Enter first name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Enter last name: ");
                        string lastName = Console.ReadLine();

                        Console.Write("Enter address: ");
                        string address = Console.ReadLine();

                        Console.Write("Enter city: ");
                        string city = Console.ReadLine();

                        Console.Write("Enter state: ");
                        string state = Console.ReadLine();

                        Console.Write("Enter zip: ");
                        string zip = Console.ReadLine();

                        Console.Write("Enter phone number: ");
                        string phoneNumber = Console.ReadLine();

                        Console.Write("Enter email: ");
                        string email = Console.ReadLine();

                        Contacts contact = new Contacts
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Address = address,
                            City = city,
                            State = state,
                            Zip = zip,
                            PhoneNumber = phoneNumber,
                            Email = email
                        };

                        addressBookManager.AddContact(addressBookName, contact);
                        break;
                    case 3:
                        Console.Write("Enter address book name: ");
                        addressBookName = Console.ReadLine();
                        addressBookManager.PrintContacts(addressBookName);
                        break;
                    case 4:
                        Console.Write("Enter address book name: ");
                        addressBookName = Console.ReadLine();

                        Console.Write("Enter first name of contact to edit: ");
                        firstName = Console.ReadLine();

                        Console.Write("Enter last name of contact to edit: ");
                        lastName = Console.ReadLine();

                        addressBookManager.EditContact(addressBookName, firstName, lastName);
                        break;
                    case 5:
                        Console.Write("Enter address book name: ");
                        addressBookName = Console.ReadLine();

                        Console.Write("Enter first name of contact to delete: ");
                        firstName = Console.ReadLine();

                        Console.Write("Enter last name of contact to delete: ");
                        lastName = Console.ReadLine();

                        addressBookManager.DeleteContact(addressBookName, firstName, lastName);
                        break;
                    case 6:
                        Console.WriteLine("Enter city to search for contacts:");
                        city = Console.ReadLine();
                        List<Contacts> contactsInCity = addressBookManager.SearchByCity(city);
                        if (contactsInCity.Count > 0)
                        {
                            Console.WriteLine("Contacts in " + city + ":");
                            foreach (Contacts contacts in contactsInCity)
                            {
                                Console.WriteLine(contacts.FirstName + " " + contacts.LastName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contacts found in " + city + ".");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Enter state to search for contacts:");
                        state = Console.ReadLine();
                        List<Contacts> contactsInState = addressBookManager.SearchByState(state);
                        if (contactsInState.Count > 0)
                        {
                            Console.WriteLine("Contacts in " + state + ":");
                            foreach (Contacts contacts in contactsInState)
                            {
                                Console.WriteLine(contacts.FirstName + " " + contacts.LastName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contacts found in " + state + ".");
                        }
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

    }
}



