using System;

class Myclass
{
    public int x;
}

class SimpleClass
{
    public static void Main()
    {
        Myclass mc  = new Myclass();

        mc.x = 10;

        Console.WriteLine("mc.x = {0}", mc.x);
    }
}