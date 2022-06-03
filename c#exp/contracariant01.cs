using System;

class Contravariant01
{
    public static void Main()
    {
        Func<object, string> md1 = PlusString;
        object obj = "猫";
        Console.WriteLine(md1(obj));

        Func<string, string> md2 = md1;
        string str = "犬";
        Console.WriteLine(md2(str));
    }
    static string PlusString(object s)
    {
        return s + "です";
    }
}