using System;

class Main01
{
    public static int Main(string[] s)
    {
        int n, i = 0;
        n = s.Length;
        Console.WriteLine("引数の個数は{0}個です", n);

        if(n != 0)
        {
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("引数{0} : {1}", i + 1, s[i]);
            }
        }
        return 0;
    }
}