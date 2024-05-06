internal class Program
{
    private static void Main(string[] args)
    {
        // remove duplicates from sorted array inplace
        var arr = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        DisplayArray(arr);
        var len = RemoveDuplicates(arr);
        DisplayArray(arr);
        Console.WriteLine($"Len - {len}");
    }

    private static void DisplayArray(int[] arr)
    {
        //Console.WriteLine(arr.ToString());
        foreach (var item in arr)
        {
            Console.Write($"{item} - ");
        }
        Console.WriteLine();
    }

    private static int RemoveDuplicates(int[] arr)
    {
        int len = 0;
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            len++;
            //int j = i + 1;
            j++;
            while (j < arr.Length && arr[i] == arr[j])
            {
                j++;
            }
            if(!(j < arr.Length))
            {
                break;
            }
            arr[i + 1] = arr[j];
        }
        return len;
    }
}