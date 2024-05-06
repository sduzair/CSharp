internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class UserWithPrivateField
{
    private string _name;
    public string Name { get => _name; set => _name = ValidateName(value); }
    public UserWithPrivateField(string name)
    {
        _name = ValidateName(name);
    }
    // Non-nullable field '_name' must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring the field as nullable.
    // public UserWithPrivateField(string name)
    // {
    //     Name = ValidateName(name);
    // }

    private static string ValidateName(string name)
    {
        throw new NotImplementedException();
    }
}

public class User(string name)
{
    private string _name = ValidateName(name);
    public string Name { get => _name; set => _name = ValidateName(value); }

    private static string ValidateName(string name)
    {
        throw new NotImplementedException();
    }

}
