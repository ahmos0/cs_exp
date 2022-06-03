using System;

class Myclass
{
    public static void Main()
    {
        double i = 0, sum = 0, value = 1;
        value = 1;
        for(i = 0; i < 30; i++)
        {
            sum += value;
            value = 2 * value;
        }
        Console.WriteLine("{0}", value);
    }
}
