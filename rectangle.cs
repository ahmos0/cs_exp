using System;
public class rectagle
{
    public static void Main()
    {
        int a = 0, b = 0, S = 0, R = 0;
        a = int.Parse(Console.ReadLine()); 
        S = a * b;
        R = 2 * a + 2 * b;
        Console.WriteLine("{0} {1}",S, R);
    }
}