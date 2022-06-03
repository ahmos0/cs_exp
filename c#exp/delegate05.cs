using System;

delegate void MyDG();

class MyClass
{
    public void Show1()
    {
        Console.WriteLine("Show1が呼ばれました");
    }
    public void Show2()
    {
        Console.WriteLine("Show2が呼ばれました");
    }
    public void Show3()
    {
        Console.WriteLine("Show3が呼ばれました");
    }
}

class Delegate05
{
    public static void Main()
    {
        MyClass mc = new MyClass();
        MyDG md = new MyDG(mc.Show1);

        Console.WriteLine("1回目のmd()を実行します");
        md += new MyDG(mc.Show2);
        Console.WriteLine("2回目のmd()を実行します");
        md();

        md += new MyDG(mc.Show3);
        Console.WriteLine("3回目のmd()を実行します");
        md();

        md -= new MyDG(mc.Show1);
        Console.WriteLine("4回目のmd()を実行します");
        md();
    }
}