using System;

class Base 
{
    public int x = 10;
    public void BaseMethod()
    {
        Console.WriteLine("Baseクラスです");
    }
}

class Derived : Base
{
    new public int x = 20;
    new public void BaseMethod()
    {
        Console.WriteLine("Derivedクラスです");
    }
}

class Inheritance03
{
    public static void Main()
    {
        Derived d = new Derived();
        Console.WriteLine("x = {0}", d.x);
        d.BaseMethod();
    }
}