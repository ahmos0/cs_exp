using Internal;
using System;
using System.Linq;
using System.Collections.Generic;

class Linq01
{
    public static void Main()
    {
        int[] numbers = new int[]{-3, 4, 1, 2, -6, 3, 100, -25};

        //クエリの作成
        IEnumerable<int>q = 
            from n in numbers
            where n > 0
            //orderby n descending
            select n;
        foreach(int x in q)
        {
            Console.WriteLine(x);
        }
    }
}