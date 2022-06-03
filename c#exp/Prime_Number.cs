using System;

class prime
{
    int count = 0;
    public static void Main()
    {
        prime mc = new prime();
        int n, i;
        n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for(i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
            if(mc.primejudge(a[i]) == true)
            {
                mc.count++;
            }
        }
        Console.WriteLine(mc.count);
    }
    
    bool primejudge(int a)
    {
        if(a == 2)
        {
            return true;
        }
        if(a < 2 || a % 2 == 0)
        {
            return false;
        }
        int i = 3;
        while(i <= Math.Sqrt(a))
        {
            if(a % i == 0)
            {
                return false;
            }
            i = i + 2;
        }
        return true;
    }
}