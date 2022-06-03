using System;

class MyClass
{
    int z;
    public int x {get; set;}
}

class Anonymous02
{
    public static void Main()
    {
        MyClass mc = new MyClass();
        mc.x = 10;
        Console.WriteLine("x = {0}", mc.x);
    }
}