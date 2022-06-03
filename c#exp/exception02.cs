using System;

class MyClass
{
    public static void Main()
    {
        double a = 0.0, b = 0.0;
        Console.Write("割られる数---");
        string strA = Console.ReadLine();
        try{
            a = double.Parse(strA);
        }
        catch{
            Console.WriteLine("不適切な入力です");
        }
        Console.Write("割る数---");
        string strB = Console.ReadLine();
        try{
            b = double.Parse(strB);
        }
        catch{
            Console.WriteLine("不適切な入力です");
        }
        Console.WriteLine("{0} / {1} = {2}", a, b, a/b);
    }
}