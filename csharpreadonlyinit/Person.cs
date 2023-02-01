public class Person
{
    public static readonly int FirstName = 7;
    public string? LastName { get; set; }
    public Person(int firstName, string lastName)
    {
        //FirstName = firstName;
        LastName = lastName;
    }
    public Person(string lastName)
    {
        LastName = lastName;
    }
    //public void changeFirstName(int firstName)
    //{
    //    FirstName = firstName;
    //}
}



