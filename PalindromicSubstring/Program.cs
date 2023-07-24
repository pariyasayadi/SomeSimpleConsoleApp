using System;

class MainClass
{
    public static string PalindromicSubstring(string str)
    {
        string longest = "none";

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j <= str.Length; j++)
            {
                string substring = str.Substring(i, j - i);
                if (IsPalindromic(substring) && substring.Length > longest.Length)
                {
                    longest = substring;
                }
            }
        }
        return longest;
    }

    public static bool IsPalindromic(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reverseStr = new string(charArray);
        return str == reverseStr;
    }

    static void Main()
    {
        Console.WriteLine(PalindromicSubstring("hellosannasmith"));
    }
}