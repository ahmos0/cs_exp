using System;

class Myclass
{
    private int temp;

    public void Swap(int x, int y);
    {
        temp = x;
        x = y;
        y = temp;
    }
}

class Swap01
{
    public static void Main()
    {
        Myclass s = new Myclass();
        int x = 10, y = 20;
        s.Swap(x, y);
        Console.WriteLine("x = {0}, y = {1}" x, y);
    }
}