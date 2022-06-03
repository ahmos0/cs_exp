using System;
delegate void MyDelegate(int x);

class Lamda03
{
    public static void Main()
    {
        MyDelegate md1 = x => Console.WriteLine("{0}の2乗は{1}", x, x * x);
        MyDelegate md2 = x => Console.WriteLine("{0}の2倍は{1}", x, x * 2);

        MyDelegate md = md1 + md2;
        md(10);
    }

}