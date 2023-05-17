namespace csharprecord;

internal record MyRecord : IComparable<MyRecord>
{
    public readonly int X;
    public readonly int Y;

    public MyRecord(int x, int y)
    {
        if (!IsValid(x, y)) throw new ArgumentException("x and y must be positive");
        X = x;
        Y = y;
    }

    public static bool IsValid(int x, int y) => x > 0 && y > 0;

    public int CompareTo(MyRecord? other)
    {
        if (other is null)
        {
            return 1;
        }
        var myVal = Math.Sqrt(X * X + Y * Y);
        var otherVal = Math.Sqrt(other.X * other.X + other.Y * other.Y);

        return myVal.CompareTo(otherVal);
    }

    public bool IsValid()
    {
        return IsValid(X, Y);
    }

}
