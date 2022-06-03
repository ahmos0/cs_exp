using System;

class Isas02
{
    public static void Main()
    {
        long l  = 100;
        object o;
        string t;

        o  = l;
        t = o as string;
        Console.WriteLine(t);
    }
}