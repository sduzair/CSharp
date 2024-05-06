namespace csharphashset
{
    public class Employee : IEquatable<Employee>
    {
        public string Name { get; private set; }
        public DateTime Dob { get; private set; }
        public Address Address { get; private set; }

        public Employee(string name, DateTime dob, Address address)
        {
            Name = name;
            Dob = dob;
            Address = address;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Dob: {Dob}, Address: {Address}";
        }

        public bool Equals(Employee? other)
        {
            return other is not null &&
                Name == other.Name &&
                Dob == other.Dob &&
                Address == other.Address;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Employee);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Dob.GetHashCode() ^ Address.GetHashCode();
        }
    }
}