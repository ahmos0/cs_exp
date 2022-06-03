using System;
using System.Linq;

class Linq04
{
    static bool MyWhere(int x)
    {
        return (x > 0);
    }
    static int MyOrderBy(int x)
    {
        return x;
    }
    static int MySelect(int x)
    {
        return x;
    }

    public static void Main()
    {
        int[] numbers = new int[]{
            200, -3, 4, 1, 2, -6, 3, 100, -25};

        //メソッド構文
        var q = numbers.Where(MyWhere)
            .OrderByDescending(MyOrderBy)
            .Select(MySelect);

        //クエリの実行
        foreach(int x in q)
            Console.WriteLine(x);
    }
}