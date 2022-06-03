using System;

class Fibo
{
    public long Calcfibo(int n)
    {
        long fibo;

        if(n == 1 || n == 2)
        {
            fibo = 1;
        }
        else
        {
            fibo = Calcfibo(n - 1) + Calcfibo(n - 2);
        }
        return fibo;
    }
}

class Fibonacci
{
    public static void Main()
    {
        Fibo f = new Fibo();
        int i = 1;

        for(i = 1; i <= 10; i++)
        {
            Console.WriteLine(
                "n = {0, 2}, f(2 * {0, 2}) = {1, 4}, " +
                "f({0, 2}) = {2, 3}, {1, 4} / {2, 3}の余り...{3}",
                i, f.Calcfibo(i * 2), f.Calcfibo(i),
                f.Calcfibo(i*2)%f.Calcfibo(i));
        }
    }
}