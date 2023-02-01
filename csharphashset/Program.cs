using csharphashset;

var employees = new List<Employee>();

for (int i = 0; i < 10000; i++)
{
    string? unit = i % 2 == 0 ? $"Apt {i % 10 + 1}" : null;
    string street = $"123 Main St {i % 10 + 1}";
    string state = "CA";
    string postalCode = $"1234{i % 10 + 1}";
    Address address = new(street, state, postalCode, unit);
    string name = $"John Doe {i % 10 + 1}";
    DateTime dob = new(1990 + i % 10, 1, 1);
    Employee employee = new(name, dob, address);
    employees.Add(employee);
}

Console.WriteLine("Employees:");
foreach (var employee in employees)
{
    Console.WriteLine(employee.ToString());
}

var hashSet = new HashSet<Employee>(employees);
Console.WriteLine($"hashSet.Count: {hashSet.Count}");

for (int i = 5; i > 0; i--)
{
    System.Console.WriteLine($"{i}");
    System.Threading.Thread.Sleep(1000);
}

Console.WriteLine($"hashSet.Contains(employees[1]){employees[1]}: {hashSet.Contains(employees[1])}");

System.Console.WriteLine();