using System;
using System.Collections.Generic;

class List02
{
    public static void Main()
    {
        List<string> names = new List<string>{"一郎", "二郎", "三郎"};

        foreach(string s in names)
        {
            Console.WriteLine(s);
        }
    }
}