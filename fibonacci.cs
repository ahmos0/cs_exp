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
        for(i = 1; i <= 30; i++)
        {
            Console.WriteLine("f{0} = {1}", i, f.Calcfibo(i));
        }
    }
}