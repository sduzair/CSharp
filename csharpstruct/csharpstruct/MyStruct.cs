namespace csharpstruct;

public readonly struct MyStruct : IComparable<MyStruct>
{
    public int FirstInt { get; }
    public int SecondInt { get; }

    private MyStruct(int value1, int value2)
    {
        FirstInt = value1;
        SecondInt = value2;
    }

    //public MyStruct() => throw new InvalidOperationException("Cannot create instance using default constructor.");

    public static MyStruct Create(int value1, int value2)
    {
        if (value1 < 0)
            throw new ArgumentException("Value must be non-negative", nameof(value1));

        if (value2 < 0)
            throw new ArgumentException("Value must be non-negative", nameof(value2));

        return new MyStruct(value1, value2);
    }

    public int CompareTo(MyStruct other)
    {
        // Compare the FirstInt property of the current instance to the FirstInt property of the specified object
        int result = FirstInt.CompareTo(other.FirstInt);

        // If the FirstInt properties are equal, compare the SecondInt properties
        if (result == 0)
        {
            result = SecondInt.CompareTo(other.SecondInt);
        }

        return result;
    }
}

