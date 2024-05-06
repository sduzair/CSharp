namespace CSharpRepeatingWords;

public class Program
{
    private static readonly List<string> delimiters = new() { " ", ",", ".", "!", "?", ";", ":", "(", ")", "[", "]", "{", "}", "\r", "\t", "\n" };
    private static readonly List<string> wordsToExclude = new() { "a", "an", "the", "is", "are", "was", "were", "be", "been", "being", "have", "has", "had", "do", "does", "did", "will", "would", "shall", "should", "may", "might", "must", "can", "could", "to", "of", "in", "on", "at", "for", "from", "by", "with", "and", "or", "but", "as", "if", "then", "else", "when", "where", "why", "how" };
    public static string GetHighestRepeatingWord(string phrase)
    {
        string[] words = phrase.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        var wordsCountDictionary = new Dictionary<string, int>();

        words.Select(word => word.ToLower()).Where(word => !wordsToExclude.Contains(word.ToLower())).ToList().ForEach(word =>
        {
            if (wordsCountDictionary.TryGetValue(word, out int value))
            {
                value++;
            }
            else
            {
                wordsCountDictionary.Add(word, 1);
            }
        });

        return wordsCountDictionary.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }

    private static void Main()
    {
        Console.WriteLine("Enter phrase to find out the highest repeating word:");
        string? phrase = Console.ReadLine();
        if (phrase is null)
        {
            Console.WriteLine("Please enter a non-empty phrase");
            return;
        }
        Console.WriteLine($"The most repeated word is: {GetHighestRepeatingWord(phrase)}");
    }
}