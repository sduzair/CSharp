using System.Text;

// string? readLine;

// do
// {
//     do
//     {
//         Console.WriteLine("Please enter a sentence (enter \"exit\" to exit):");
//         readLine = Console.ReadLine();
//     } while (string.IsNullOrEmpty(readLine));

//     if (readLine == "exit") break;

//     System.Console.WriteLine($"{readLine} -> {ReverseEachWord(readLine)}\n");

// } while (true);

string readLine = "Hello World! Hope you are having a great day";

var startTime = DateTime.Now;
for (int i = 0; i < 500; i++) ReverseEachWord(readLine);
// System.Console.WriteLine($"{readLine} -> {ReverseEachWord(readLine)}\n");

System.Console.WriteLine($"{DateTime.Now - startTime}");

startTime = DateTime.Now;
for (int i = 0; i < 500; i++) ReverseEachWordWitoutStringBuilder(readLine);
// System.Console.WriteLine($"{readLine} -> {ReverseEachWordWitoutStringBuilder(readLine)}\n");

System.Console.WriteLine($"{DateTime.Now - startTime}");

string ReverseEachWordWitoutStringBuilder(string sentence)
{
    string finalString = "";
    string[] words = sentence.Split(' ');

    foreach (var word in words)
    {
        finalString += ReverseWord(word);
        if (!IsLastWord(words, word)) finalString += ' ';
    }
    return finalString;
}

string ReverseEachWord(string sentence)
{
    var stringBuilder = new StringBuilder();
    stringBuilder.EnsureCapacity(sentence.Length);

    string[] words = sentence.Split(' ');

    foreach (var word in words)
    {
        stringBuilder.Append(ReverseWord(word));
        if (!IsLastWord(words, word)) stringBuilder.Append(' ');
    }
    return stringBuilder.ToString();
}

string ReverseWord(string word)
{
    if (word.Length == 1) return word;
    return word.Substring(word.Length - 1) + ReverseWord(word.Substring(0, word.Length - 1));
}

static bool IsLastWord(string[] words, string word)
{
    return words[words.Length - 1] == word;
}