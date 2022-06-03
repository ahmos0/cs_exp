using System;

class Divisor
{
    public static void Main()
    {
        int a = 0, b = 0, c = 0;
        bool x = true;
        var line = Console.ReadLine().Split(' ');
        a = int.Parse(line[0]);
        b = int.Parse(line[1]);
        while(x)
        {
            c = a % b;
            if(c == 0)break;
            a = b;
            b = c;
        }
        Console.WriteLine(b);

    }
}