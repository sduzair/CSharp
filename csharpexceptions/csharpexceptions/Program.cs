try
{
    int a = 4;
    int b = 0;
    int c = a / b;
    System.Console.WriteLine($"{a} / {b} = {c}");
}
catch (Exception ex)
{
    // Console.WriteLine(ex.Message);
    throw new ApplicationException("An error occurred", ex);
}

Console.ReadLine();

// Hold Alt + 1 + 7 + 8 + Release Alt
// ▓▓▓▓▓▓▓▓▓▓
// ▓▓▓▓▓▓▓▓▓▓
// ▓▓▓▓▓▓▓▓▓▓