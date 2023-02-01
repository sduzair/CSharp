using csharppalindrome;

Console.WriteLine("Enter a word: ");
string word = Console.ReadLine();
var result = PalindromeChecker.IsPalindrome(word);
Console.WriteLine($"Is the word a Palindrome? {result}");

var formattedWord = word.ToLower()
    .ToUpper();
System.Console.WriteLine($"Formatted Word: {formattedWord}");