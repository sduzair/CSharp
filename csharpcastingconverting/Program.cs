// Casting -> Truncates
int value = (int)1.5m;
System.Console.WriteLine(value);    // Output: 1

// invalid - parse works for string as input 
// int value2 = int.TryParse(1.5m, out value2);

// Converting -> Rounds
int value3 = Convert.ToInt32(1.5m);
System.Console.WriteLine(value3);   // Output: 2