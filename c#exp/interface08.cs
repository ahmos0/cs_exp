using System;

interface I1
{
    void Show1();
    void Show2();
}

interface I2 : I1
{
    new void Show1();
}

class Myclass : I2
{
    void I1.Show1()
    {
        Console.WriteLine("I1.Show1");
    }
    void I2.Show1()
    {
        Console.WriteLine("I2.Show1");
    }
    public void Show2()
    {
        Console.WriteLine("Show2");
    }
}

class Interface08
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        I1 i1;
        I2 i2;

        mc.Show2();

        i1 = mc;
        i1.Show1();

        i2 = mc;
        i2.Show1();
        i2.Show2();
    }
}