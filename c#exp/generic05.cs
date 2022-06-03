using System;

class MyClass<T, U>
{
    public T x;
    public U y;
}

class MyClass2<T> : MyClass<T, int>
{
    public void Show()
    {
        Console.WriteLine("x = {0}, y = {1}", x, y);
    }
}

class Generic05
{
    public static void Main()
    {
        MyClass2<string>  mc = new MyClass2<string>();
        mc.x = "cat";
        mc.y = 20;
        mc.Show();
    }
}