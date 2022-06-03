using System;

class Profit
{
    public static void Main()
    {
        int n = 0, i = 0, j = 0, x = 0;
        double Max = -99999999999;
        n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for(i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        for(i = n - 1; i >= 0; i--)
        {
            for(j = i - 1; j >= 0; j--)
            {
                x = a[i] - a[j];
                if(Max < x)
                {
                    Max = x;
                }
            }   
        }
        Console.WriteLine(Max);
    }
}