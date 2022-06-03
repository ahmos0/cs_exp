using System;
using System.Linq;

class Linq05
{
    public static void Main()
    {
        int[] numbers = new int[]{
            200, -3, 4, 1, 2, -6, 3, 100, -25};

        var q = numbers.Where(delegate(int x){return x > 0;})
            .OrderByDescending(delegate(int x){return x;})
            .Select(delegate(int x){return x;});

        foreach(int x in q)
        {
            Console.WriteLine(x);
        }
    }
}