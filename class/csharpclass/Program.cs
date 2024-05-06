using csharpclass;

var array = new Person[3];  //limitation of c# arrays is that they cicumvent the constructor and create an empty object

foreach (var person in array)
{
    Console.WriteLine(person);
}

var person1 = new Person("John", "Doe", "jondoe@emial.com");

Console.WriteLine(person1);

Console.ReadLine();
