using System;

class MyClass<T>
{
    public T x;
}

class MyClass2 : MyClass<int>
{
    public void Show()
    {
        Console.WriteLine(x);
    }
}

class Generic03
{
    public static void Main()
    {
        MyClass2 mc = new MyClass2();
        mc.x = 10;
        mc.Show();
    }
}