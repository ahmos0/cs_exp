using System;

class array04
{
    public static void Main()
    {
        int i = 0, j = 0, k = 0;
        int[,,]ar = new int[2,2,3]
        {
            {
                {0, 1, 2},
                {3, 4, 5}
            },
            {
                {6, 7, 8},
                {9, 10, 11}
            }
        };

        Console.WriteLine("配列の次元 = {0}",ar.Rank);
        Console.WriteLine("arの個数 = {0}", ar.Length);
        for(i = 0; i < 2; i++)
        {
            for(j = 0; j < 2; j++)
            {
                for(k = 0; k < 3; k++)
                {
                    Console.Write("{0}, ", ar[i,j,k]);
                }
            }
        }
        Console.WriteLine();
    }
}