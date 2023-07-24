using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{

    public static string GroupTotals(string[] strArr)
    {
        Dictionary<string, int> totals = new Dictionary<string, int>();
        foreach (string pair in strArr)
        {
            string[] keyValue = pair.Split(':');
            string key = keyValue[0];
            int value = int.Parse(keyValue[1]);
            if (totals.ContainsKey(key))
            {
                totals[key] += value;
            }
            else
            {
                totals[key] = value;
            }
        }
        var fliteredTotals = totals.Where(k => k.Value != 0).OrderBy(x => x.Key);
        string result = string.Join(",", fliteredTotals.Select(x => x.Key + ":" + x.Value));
        // code goes here  
        return result;

    }

    public static void Main(string[] args)
    {

        // keep this function call here
        //Console.WriteLine(GroupTotals(Console.ReadLine()));
        Console.WriteLine(GroupTotals(new string[] { "B:-1", "A:1", "B:3", "A:5" }));
    }

}