using System;

delegate int MyDelegate(int x, int y);

class Lamda02
{
    public static void Main()
    {
        MyDelegate md = (x, y) => {return x + y;};

        Console.WriteLine("2 + 3 = {0}", md(2, 3));
    }
}