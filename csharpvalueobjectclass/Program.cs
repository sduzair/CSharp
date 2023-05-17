using csharpvalueobjectclass;
using Xunit;

var addressA = new Address("123 Main St", "Anytown", "USA");

var addressB = new Address("123 Main St", "Anytown", "USA");

var addressC = new Address("456 Main St", "Anytown", "USA");

Assert.True(addressA == addressB);

Assert.False(addressA == addressC);

Address[] addresses = new []{ addressA, addressB, addressC }.OrderBy(x => x).ToArray();

foreach (var address in addresses)
{
    Console.WriteLine(address);
}