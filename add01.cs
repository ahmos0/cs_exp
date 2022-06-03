using System;

class Add01
{
    public static void Main()
    {
        Console.WriteLine(3 + 6);
        Console.WriteLine(3.0 + 6);
        Console.WriteLine("3.5" + 6);
        Console.WriteLine(3.5 + "6");
        Console.WriteLine();
        Console.WriteLine("(3.0 + 6)の型は{0}",(3.0 + 6).GetType());
        Console.WriteLine("(文字列3.5 + intの6の型は{0}",("3.5" + 6).GetType());
        Console.WriteLine("doubleの3.5 + 文字列の6の型は{0}",(3.5 + "6").GetType());
    }
}