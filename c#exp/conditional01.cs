using Internal;
using System;
using System.Diagnostics;

class MyClass
{
    public string name;
    [Conditional("TEST")]
    public void Show()
    {
        Console.WriteLine(name);
    }
}
class Conditional01
{
    public static void Main()
    {
        MyClass mc = new MyClass();
        mc.name = "マイケル";
        mc.Show();
    }
}