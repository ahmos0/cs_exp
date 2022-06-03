using System;

class A1
{
    public int Calc(int a, int b)
    {
        return a + b;
    }
}

class A2 : A1
{
    new public int Calc(int a, int b)
    {
        return a - b;
    }
}

class A3
{
    public static void Main()
    {
        A2 a2 = new A2();
        A1 a1;

        a1 = a2;
        Console.WriteLine("a2.Calc(3, 5) = {0}", a2.Calc(3, 5));
        Console.WriteLine("a1.Calc(3, 5) = {0}", a1.Calc(3, 5));
    }
}