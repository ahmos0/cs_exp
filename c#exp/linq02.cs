using Internal;
using System;
using System.Linq;
using System.Collections.Generic;

class Linq02
{
    public static void Main()
    {
        string[] myStr = {"flower", "cat", "dog", "bird", "rabbit"};

        IEnumerable<string> q = 
            from s in myStr
            where s.Length >= 4
            orderby s descending
            select s;

        foreach(string x in q)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine("適合した数 = {0}", q.Count());
    }
}