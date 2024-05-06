namespace csharpvalueobjects
{
    public sealed class ContactList
    {
        private static readonly Lazy<ContactList> _contactList = new(() => new ContactList());

        public static ContactList ContactListInstance => _contactList.Value;

        private ContactList() { }

        public static List<Person> Contacts { get; private set; } = new();

        public static void AddContact(Person person)
        {
            // Contacts.Add(person);
            Contacts.Add(new Person(person.Name, person.PhoneNumber));
        }

        public static Person? UpdateContactByName(string name, string newPhoneNumber)
        {
            Person? person = Contacts.FirstOrDefault(p => p.Name == name);

            person?.UpdatePhoneNumber(newPhoneNumber);

            return person;
        }

        public static void PrintContacts()
        {
            foreach (Person contact in Contacts)
            {
                Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}");
            }
        }
    }
}