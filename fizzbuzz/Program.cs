var divisors = new Dictionary<int, string>()
{
    { 3, "Fizz" },
    { 5, "Buzz" },
    { 7, "Bazz" },
};

for (int i = 1; i <= 100; i++)
{
    System.Console.Write($"{i} - ");
    foreach (int key in divisors.Keys)
    {
        if (i % key == 0)
        {
            System.Console.Write($"{divisors[key]}");
        }
    }
    System.Console.WriteLine();
}