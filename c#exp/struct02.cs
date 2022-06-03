using System;

struct Mystruct
{
    public static int x = 10;
    static int[] myArray = new int[10];

    public static void Show()
    {
        Console.WriteLine("x = {0}", x);
    }
}

class Struct02
{
    public static void Main()
    {
        Mystruct.Show();
        Mystruct.x = 20;
        Mystruct.Show();
    }
}
