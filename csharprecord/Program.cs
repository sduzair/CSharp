using csharprecord;
using Xunit;

var x = new MyRecord(3, 4);

var y = new MyRecord(5, 12);

var z = new MyRecord(8, 15);

var a = new MyRecord(3, 4);

//var b = new MyRecord();

//EQUALITY

Assert.Equal(x, a);

Assert.True(x == a);

//ARRAY

//analyzer does not see the problem here when IComparable is not implemented
MyRecord[] myRecords = new[] { x, y, z }.OrderBy(x => x).ToArray();

foreach (var item in myRecords)
{
    Console.WriteLine(item);
}

//SORTED LIST

var list = new List<MyRecord> { x, z, y };

//analyzer does not see the problem here when IComparable is not implemented
list.Sort();

//Assert.True(list[1] == y && list[2] == z && list[1].CompareTo(list[2]) < 0);

foreach (var item in list)
{
    Console.WriteLine(item);
}

//HASHSET

var set = new HashSet<MyRecord> { x, z, y };

var p = new MyRecord(3, 4);
Assert.True(set.Contains(p));

//WITH EXPRESSION   <-- init supports use of with expression - init is similar to readonly is the sense that property is set in constructor

//var x2 = x with { Y = -4 };

//Assert.True(x2.IsValid());
