using System;

class fact 
{
    public long Calcfact(int n)
    {
        long fact;
        if(n == 0)
        {
            fact = 1;
        }
        else
        {
            fact = n * Calcfact(n -1);
        }
        return fact;
    }
}

class Fact01
{
    public static void Main()
    {
        fact f = new fact();
        int i = 0;
        for(i = 0; i <= 20; i++)
        {
            Console.WriteLine("{0}! = {1}", i, f.Calcfact(i));
        }
    }
}