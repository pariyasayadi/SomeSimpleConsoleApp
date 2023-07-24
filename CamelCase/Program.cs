using System;
using System.Text.RegularExpressions;

class MainClass
{

    public static string CamelCase(string str)
    {

        // code goes here  
        string[] words = Regex.Split(str, @"[^A-Za-z]+");
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);

            }
        }
        string result = string.Join("", words);
        result = char.ToLower(result[0]) + result.Substring(1);

        return result;

    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(CamelCase("ParIyA loves-coding"));
        Console.WriteLine(CamelCase("cats AND*Dogs-are Awesome"));

    }

}