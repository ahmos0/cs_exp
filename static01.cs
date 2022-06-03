using System;

class Myclass
{
    public static int x;

    public static void ShowX()
    {
        Console.WriteLine("x = {0}", x);
    }
}

class Static01
{
    public static void Main()
    {
        Myclass.x = 10;
        Myclass.ShowX();
    }
}