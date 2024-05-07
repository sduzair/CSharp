using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var iRoleTypes = Assembly.GetExecutingAssembly()
                                 .GetTypes()
                                 .Where(t => t.IsAbstract && t.IsClass && t.GetInterfaces().Contains(typeof(IRole)));

        foreach (var iRoleType in iRoleTypes)
        {
            Console.WriteLine(iRoleType.Name);
        }
    }
}

public interface IRole { }

public abstract class Admin : IRole { }

public abstract class User : IRole { }

public abstract class Guest : IRole { }
