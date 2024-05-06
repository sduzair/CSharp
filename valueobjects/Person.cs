namespace csharpvalueobjects
{
    public class Person
    {
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }

        public Person(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public void UpdatePhoneNumber(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
        }
    }
}