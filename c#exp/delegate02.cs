using System;

delegate void MyDelegate();

class MyClass
{
    public void Show()
    {
        Console.WriteLine("呼ばれました");
    }
}

class Delegate02
{
    public static void Main()
    {
        MyClass mc = new MyClass();
        mc.Show();

        MyDelegate m = new MyDelegate(mc.Show);
        m();
    }
}