using System.Diagnostics.Tracing;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(GetLongestCommonPrefix(args));
    }
    private static string GetLongestCommonPrefix(string[] words)
    {
        string smallestWord = GetSmallestWord(words);
        StringBuilder longestCommonPrefix = new();
        Boolean tag = true;
        for (int i = 0; i < smallestWord.Length; i++)
        {
            foreach (var word in words)
            {
                if (word[i] != smallestWord[i]) tag = false; 
            }
            if (!tag) break;
            longestCommonPrefix.Append(smallestWord[i]);
        }
        return longestCommonPrefix.ToString();
    }

    private static string GetSmallestWord(string[] words)
    {
        int min = int.MaxValue;
        StringBuilder smallestWord = new();

        foreach (var word in words)
        {
            if (min > word.Length)
            {
                min = word.Length;
                smallestWord.Clear();
                smallestWord.Append(word);
            }
        }

        return smallestWord.ToString();
    }
}