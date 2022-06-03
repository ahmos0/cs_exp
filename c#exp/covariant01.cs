using System;
using System.Collections.Generic;

class Covariant01
{
    public static void Main()
    {
        IEnumerable<string> myStr = new[]{"猫","でも","わかる","C#"};
        IEnumerable<object> myObj = myStr;
        foreach(string s in myStr)
        {
            Console.Write(s);
        }
        Console.WriteLine();

        foreach(object o in myObj)
        {
            Console.Write(o);
        }
        Console.WriteLine();
    }
}