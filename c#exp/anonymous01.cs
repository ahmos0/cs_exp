using System;

class MyClass
{
    int z;
    public int x
    {
        get{
            return z;
        }
        set{
            z = value;
        }
    }
}

class Anonymous01
{
    public static void Main()
    {
        MyClass mc = new MyClass();
        mc.x = 10;
        Console.WriteLine("x = {0}", mc.x);
    }
}