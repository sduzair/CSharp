using System.Diagnostics;

/*
    Type 1 2D Array:
        -With foreach possible to iterate through but not possible to differentiate dimension 
*/
var array2dType1 = new string[2, 2]
{
    {"one", "two"},
    {"tree", "four" }
};

Debug.Assert(array2dType1.Length == 4);

// iterating through type 1
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        System.Console.Write(array2dType1[i, j] + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

// alternative to iterate through type 1
for (int i = 0; i < array2dType1.Length; i++)
{
    int x = i / 2;
    int y = i % 2;
    System.Console.Write(array2dType1[x, y] + "\t");
    if (y == 2 - 1) System.Console.WriteLine();
}
System.Console.WriteLine();


// Jagged Array type
var array2dType2 = new string[2][]
{
    new string [] {"one", "two"},
    new string [] {"three", "four", "five"}
};

// iterating through Jagged array
for (int i = 0; i < array2dType2.Length; i++)
{
    for (int j = 0; j < array2dType2[i].Length; j++)
    {
        System.Console.Write(array2dType2[i][j] + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();


// alternative way to iterate with foreach construct
foreach (var array in array2dType2)
{
    foreach (var x in array)
    {
        System.Console.Write(x + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();