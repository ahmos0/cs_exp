using System;

interface IFirst
{
    void Show(int x);
}

interface ISecond : IFirst
{
    void Show(int x, int y);
}

class Myclass : IFirst, ISecond
{
    public void Show(int x)
    {
        Console.WriteLine("x = {0}", x);
    }
    public void Show(int x, int y)
    {
        Console.WriteLine("x = {0}, y = {1}", x, y);
    }
}

class Interface04
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        mc.Show(2);
        mc.Show(1, 3);
    }
}