using System;

interface IMyInterface
{
    void Show1();
    void Show2();

}

interface IMyInterface2 : IMyInterface
{
    new void Show1();
    void Show3();
}

class Myclass : IMyInterface2
{
    public void Show1()
    {
        Console.WriteLine("Show1");
    }
    public void Show2()
    {
        Console.WriteLine("Show2");
    }
    public void Show3()
    {
        Console.WriteLine("Show3");
    }
}

class Interface07
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        mc.Show1();
        mc.Show2();
        mc.Show3();
    }
}