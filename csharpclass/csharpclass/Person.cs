namespace csharpclass;

internal class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Person(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    private Person() : this("default", "default", "default") { }
    public override string ToString()
    {
        return $"First Name: {FirstName}, Last Name: {LastName}, Email: {Email}";   
    }
}
