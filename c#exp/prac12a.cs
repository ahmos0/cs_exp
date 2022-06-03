using System;

delegate int Per(int a, int b);

class Mulitple
{
    public int Multi(int x, int y)
    {
        return x + y;
    }
    public int Decrease(int x, int y)
    {
        return x - y;
    }
}

class prac12
{
    public static void Main()
    {
        Mulitple m = new Mulitple();
        Per p1 = (a, b) => m.Multi(a,b);
        Per p2 = (a, b) => m.Decrease(a, b);

        Console.WriteLine(p1(10, 20));
        Console.WriteLine(p2(10, 20));
    }
}