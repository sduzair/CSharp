System.Console.WriteLine("Enter \"exit\" to stop reversing strings");
do
{
    string? word;
    do
    {
        word = Console.ReadLine();
    } while (string.IsNullOrEmpty(word));

    if (word.Trim().ToLower() == "exit") break;

    string reverse = ReverseString(word);

    System.Console.WriteLine($"{word} -> {reverse}");

} while (true);

static string ReverseString(string word)
{
    if (word.Length == 1) return word;
    return word.Substring(word.Length - 1) + ReverseString(word.Substring(0, word.Length - 1));
}