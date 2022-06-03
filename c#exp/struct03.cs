using System;

struct Mystruct
{
    public int x;

    public Mystruct(int a)
    {
        x = a;
    }
}

class Struct03
{
    public static void Main()
    {
        Mystruct ms = new Mystruct();
        Console.WriteLine("ms.x = {0}", ms.x);


        Mystruct ms2 = new Mystruct(100);
        Console.WriteLine("ms2.x = {0}", ms2.x);

        Mystruct ms3;
        ms3 = ms2;

        Console.WriteLine("ms3.x = {0}", ms3.x);

        ms3.x = 50;

        Console.WriteLine("ms2.x = {0}", ms2.x);
    }
}
