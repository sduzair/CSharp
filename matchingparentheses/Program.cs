public class Program
{
    private static void Main()
    {

        Console.WriteLine("Enter a word to perform Parenthesis Matching");
        string? word = Console.ReadLine();
        if (DoParenthesisMatch(word!))
        {
            Console.WriteLine("Parenthesis are balanced or no parenthesis");
        }
        else
        {
            Console.WriteLine("Parenthesis are not balanced");
        }
    }

    private static readonly Dictionary<char, char> parenthesisDictionary = new()
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

    public static bool DoParenthesisMatch(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            Console.WriteLine("Please enter a non-empty word");
            return false;
        }
        Stack<char> parenthesisStack = new();
        foreach (char ch in word)
        {
            if (IsCharOpeningParenthesis(ch))
            {
                parenthesisStack.Push(ch);
            }
            else if (parenthesisStack.Count > 0 && IsCharClosingParenthesis(ch))
            {
                if (parenthesisStack.Pop() == parenthesisDictionary[ch])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            else if (parenthesisStack.Count == 0 && IsCharClosingParenthesis(ch))
            {
                return false;
            }
        }
        return parenthesisStack.Count == 0;
    }

    private static bool IsCharClosingParenthesis(char ch)
    {
        return parenthesisDictionary.ContainsKey(ch);
    }

    private static bool IsCharOpeningParenthesis(char ch)
    {
        return parenthesisDictionary.ContainsValue(ch);
    }
}