using System;

class myclass02
{
    public int x;
}

class simpleclass02
{
    public static void Main()
    {
        myclass02 a, b;
        a = new myclass02();
        b = new myclass02();
        a.x = 10;
        b.x = 20;
        Console.WriteLine("a.x = {0}, b.x = {1}", a.x, b.x);
    }
}