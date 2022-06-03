using System;

class Myclass
{
    public int x;
}

class SimpleClass03
{
    public static void Main()
    {
        Myclass a, b;
        a = new Myclass();
        a.x = 10;
        b = a;
        Console.WriteLine("b.x = {0}", b.x);
        b.x = 100;
        Console.WriteLine("a.x = {0}", a.x);
    }
}