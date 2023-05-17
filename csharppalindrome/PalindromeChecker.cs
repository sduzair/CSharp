namespace csharppalindrome
{
    // [DebuggerNonUserCode]

    {
        private static List<string> numbers = new() {
            "2",
            "4",
        };
        public static bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
