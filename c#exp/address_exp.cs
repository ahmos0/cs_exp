using System;

class address
{
    public static void Main()
    {
        int[] a = new int[5];
        int[] b = new int[8];
        for(int i = 0; i < 5; i++)
        {
            a[i] = 5;
        }
        for(int i = 0; i < 8; i++)
        {
            b[i] = 4;
        }
        b = a;
        b[3] = 70;
        Console.WriteLine(a[3]);
    }
}