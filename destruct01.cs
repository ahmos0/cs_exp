using System;

class Destructtest
{
    int x;
    
    ~Destructtest()
    {
        Console.WriteLine("デストラクタが呼ばれました");
        Console.WriteLine("xは{0}です", x);

    }
    public Destructtest(int n)
    {
        Console.WriteLine("コンストラクタが呼ばれました");
        x = n;
        Console.WriteLine("xに{0}を代入しました", n);
    }
}

class Destruct
{
    public static void Main()
    {
        Destructtest dt1 = new Destructtest(1);
        Console.WriteLine(dt1);
        Console.WriteLine("dt1生成");
        Destructtest dt2 = new Destructtest(2);
        Console.WriteLine(dt2);
        Console.WriteLine("dt2生成");
        Destructtest dt3 = new Destructtest(3);
        Console.WriteLine(dt3);
        Console.WriteLine("dt3生成");
    }
}