using System;


interface IMyInterface
{
    void Show(string str);
}

class Myclass : IMyInterface //IMyInterfaceの実装
{
    public void Show(string s)
    {
        Console.WriteLine(s);
    }
}

class Yourclass :IMyInterface
{
    public void Show(string x)
    {
        Console.WriteLine("{0}が入力されました", x);
    }
}

class Interface02
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        Yourclass yc = new Yourclass();
        mc.Show("abc");
        yc.Show("abc");
    }
}