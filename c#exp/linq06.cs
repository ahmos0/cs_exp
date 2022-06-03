using System;
using System.Linq;

class Linq06
{
    public static void Main()
    {
        int[] numbers = new int[]{
            200, -3, 4, 1, 2, -6, 3, 100, -25};

        var q = numbers.Where(x => x > 0)
            .OrderByDescending(x => x)
            .Select(x => x);
        
        foreach(int x in q)
        {
            Console.WriteLine(x);
        }
    }
}