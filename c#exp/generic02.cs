using System;

class MyClass<T, U>
{
    public T[] x;
    public U[] y;

    public MyClass(int n)
    {
        x = new T[n];
        y = new U[n];
    }
}

class Generic02
{
    public static void Main()
    {
        int n;

        Console.Write("n = ");
        string strN = Console.ReadLine();
        if(!Char.IsDigit(strN[0]))
        {
            Console.WriteLine("入力が不適切です");
            return;
        }
        n = int.Parse(strN);
        MyClass<int, string> mc = new MyClass<int,  string>(n);

        for(int i = 0; i < n; i++)
        {
            Console.Write("番号---");
            string strNo = Console.ReadLine();
            if(!Char.IsDigit(strNo[0]))
            {
                Console.WriteLine("不適切な番号です");
                break;
            }
            mc.x[i] = int.Parse(strNo);

            Console.Write("氏名---");
            string strname = Console.ReadLine();
            mc.y[i] = strname;
        }
        Console.WriteLine();

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("[{0}] {1}", mc.x[i], mc.y[i]);
        }
    }
}