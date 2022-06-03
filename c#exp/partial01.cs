using System;

partial class Myclass
{
    public int x;
}

class Partial01
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        mc.x = 10;
        mc.Show();
    }
}

partial class Myclass
{
    public void Show()
    {
        Console.WriteLine("x = {0}", x);
    }
}