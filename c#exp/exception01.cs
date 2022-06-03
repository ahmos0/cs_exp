using System;

class MyClass
{
    public static void Main()
    {
        Console.WriteLine("割られる数---");
        string strA = Console.ReadLine();
        double a = double.Parse(strA);

        Console.Write("割る数---");
        string strB = Console.ReadLine();
        double b = double.Parse(strB);

        Console.WriteLine("{0} / {1} = {2}", a, b, a/b);
    }
}