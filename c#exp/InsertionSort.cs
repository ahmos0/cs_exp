using System;

class Insertion
{
    public static void Main()
    {
        Insertion mc = new Insertion();
        int n, i;
        Console.WriteLine("nを入力してください");
        n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for(i = 0; i < n; i++)
        {
            Console.WriteLine("数字を入力してちょ");
            a[i] = int.Parse(Console.ReadLine());
        }
        mc.insertion(a, n);
    }
    
    void insertion(int[] a, int n)
    {
        int i = 0, j = 0, k = 0, v = 0;
        for(i = 0; i < n; i++)
        {
            j = i - 1;
            v = a[i];
            while(j >= 0 && a[j] > v)
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = v;
        }
        for(k = 0; k < n; k++)
        {
            if(k != n - 1)
            {
                Console.Write(a[k] + " ");
            }
            else
            {
                Console.WriteLine(a[k]);
            }
        }
    }
}