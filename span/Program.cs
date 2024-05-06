var intArray = new int[] { 1, 2, 3, 4, 5 };

System.Console.WriteLine("Array:");
foreach (var number in intArray)
{
  System.Console.WriteLine(number);
}

var intSpan = new Span<int>(intArray, 1, 3);

System.Console.WriteLine("Span:");
foreach (var number in intSpan)
{
  System.Console.WriteLine(number);
}

