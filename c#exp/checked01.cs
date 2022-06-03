using System;

class Checked01
{
    public static void Main()
    {
        int x, y, z;

        x = int.MaxValue;
        y = 1;
        z = x + y;

        Console.WriteLine(z);
    }
}