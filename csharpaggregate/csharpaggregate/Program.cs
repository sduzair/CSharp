using Xunit;

var intArray = new int[] { 5, 2, 3, 4, 1 };

int sum = intArray.Aggregate(0, (a, v) => a + v);

Assert.True(sum == 15);

Array.Sort(intArray);

for (int i = 1; i < intArray.Length; i++)
    Assert.True(intArray[i - 1] <= intArray[i]);
