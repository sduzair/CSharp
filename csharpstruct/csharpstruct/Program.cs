// See https://aka.ms/new-console-template for more information
using csharpstruct;
using Xunit;

var x = MyStruct.Create(3, 4);

var y = MyStruct.Create(3, 5);

var z = new MyStruct();

//var a = x with { FirstInt = 0 };    //the property needs to have a setter for this to work

var array = new MyStruct[] { x, y, z };

Array.Sort(array);

foreach (var item in array)
{
    Console.WriteLine(item);
}

Assert.True(z.FirstInt == 0);

//Assert.True(x.Equals(y));
//Assert.True(x == y);

//Assert.True(x.Equals(y));

Console.ReadLine();
