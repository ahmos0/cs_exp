using System;

class MyClass<T>
{
    public T x;
}

class MyClass2<T> : MyClass<T>
{
    public void Show()
    {
        Console.WriteLine(x);
    }
}

class Generic04
{
    public static void Main()
    {
        MyClass2<int> mc = new MyClass2<int>();

        mc.x = 2;
        mc.Show();

        MyClass2<string> mc2 = new MyClass2<string>();
        mc2.x = "test";
        mc2.Show();
    }
}