using System;

class Mybase
{
    public virtual void Method()
    {
        Console.WriteLine("MyBase");
    }
}

class Derived1 : Mybase
{
    public override void Method()
    {
        Console.WriteLine("Derived1");
    }
}

class Derived2 : Mybase
{
    public override void Method()
    {
        Console.WriteLine("Derived2");
    }
}

class Override01
{
    public static void Main()
    {
        Derived1 d1 = new Derived1();
        Derived2 d2 = new Derived2();

        d1.Method();
        d2.Method();
    }
}