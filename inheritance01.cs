using System;

class Mybase
{
    public int a = 10;
    public void baseMethod()
    {
        Console.WriteLine("ここは基本クラスです");
    }
}

class MyDerived : Mybase
{
    public int b = 20;
    public void DerivedMethod()
    {
        Console.WriteLine("ここは派生クラスです");
    }
}

class Inheritance01
{
    public static void Main()
    {
        MyDerived md = new MyDerived();
        md.baseMethod();
        md.DerivedMethod();
        Console.WriteLine("md.a = {0}", md.a);
        Console.WriteLine("md.b = {0}", md.b);
        Mybase mb = new Mybase();
        mb.baseMethod();
        Console.WriteLine("mb.a = {0}", mb.a);
    }
}