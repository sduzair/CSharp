using csharpvalueobjects;

Person person = new("John", "555-555-5555");
Person person2 = new("Sally", "666-666-6666");

ContactList.AddContact(person);
ContactList.AddContact(person2);

person2.UpdatePhoneNumber("777-777-7777");
ContactList.PrintContacts();



// System.Console.WriteLine($"newName: {newName}");
// System.Console.WriteLine($"person.Name: {person.Name}");