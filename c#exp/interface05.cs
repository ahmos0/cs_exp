using System;

public interface IDes
{
    void Show(int i);
}

public interface IDa
{
    void Show(int i);
}

class Myclass :IDes, IDa
{
    void IDes.Show(int i)
    {
        Console.WriteLine("iは{0}です", i);
    }
    void IDa.Show(int i)
    {
        Console.WriteLine("iは{0}だ", i);
    }
}

class Interface05
{
    public static void Main()
    {
        IDes ides;
        IDa ida;
        Myclass mc = new Myclass();

        ides = mc;
        ides.Show(5);
        ida = mc;
        ida.Show(5);
    }
}