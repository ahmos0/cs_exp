using System;

struct Mystruct
{
    public int x;
    public void Show()
    {
        Console.WriteLine("x = {0}", x);
    }
}

class Struct01
{
    public static void Main()
    {
        Mystruct ms;
        ms.x = 10;
        ms.Show();
    }
}