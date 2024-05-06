Queue<int> queue = new();

void PrintFirstNBinaryNumbers(int n)
{
    if (n <= 0)
    {
        Console.WriteLine("n has to be greater than 0");
        return;
    }
    if (n == 1)
    {
        queue.Enqueue(n);
        return;
    }
    PrintFirstNBinaryNumbers(n - 1);
    int current = queue.Dequeue();
    Console.WriteLine(current);
    queue.Enqueue(current * 10);
    queue.Enqueue((current * 10) + 1);
}

System.Console.WriteLine("Enter a positive int: ");

int n;
try
{
    n = int.Parse(System.Console.ReadLine()!);
}
catch (System.Exception)
{
    System.Console.WriteLine("Invalid input");
    return;
}
PrintFirstNBinaryNumbers(n);
Console.WriteLine(queue.TryDequeue(out int result) ? result : "Queue is empty");
/*
1
10
11
100
101
110
111
1000
1001
*/