using System.Text;

namespace csharpll
{
    public class Employee
    {
        public string Name { get; private set; }
        public DateTime Dob { get; private set; }
        public Employee(string name, DateTime dob)
        {
            Name = name;
            Dob = dob;
        }
        public override string ToString()
        {
            StringBuilder outputString = new();
            _ = outputString.Append($"Name: {Name}, ");
            _ = outputString.Append($"Dob: {Dob.ToString("dd/MM/yyyy")}");
            return outputString.ToString();
        }
    }
}