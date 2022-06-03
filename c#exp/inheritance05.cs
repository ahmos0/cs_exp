using System;

class MyBase
{
    protected int x = 10;
    public virtual void Show()
    {
        Console.WriteLine("x = {0}", x);
    }
}

class Derived1 : MyBase
{
    protected int y = 20;
}

class Derived2 : Derived1
{
    int z = 30;
    public override void Show()
    {
        Console.WriteLine("z = {0}", z);
    }
}

class Inheritance05
{
    public static void Main()
    {
        MyBase mb;
        Derived1 d1 = new Derived1();
        Derived2 d2 = new Derived2();

        mb = d1;
        mb.Show();

        mb = d2;
        mb.Show();
    }
}