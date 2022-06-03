using System;

interface IC
{
    int Count(string str);
}

class myclass : IC
{
    public int Count(string s)
    {
        int a = s.Length;
        return a;
    }
}

class prac10
{
    public static void Main()
    {
        myclass mc = new myclass();
        Console.WriteLine(mc.Count("agfwag"));
    }
}