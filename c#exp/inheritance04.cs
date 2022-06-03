using System;
 

class Base
{
    protected int x = 10;
}

class Derived : Base
{
    new int x = 20;
    public void Show()
    {
        Console.WriteLine("base.x = {0}, x = {1}", base.x, x);
    }
}

class Inheritance04
{
    public static void Main()
    {
        Derived d = new Derived();
        d.Show();
    }
}