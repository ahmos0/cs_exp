using System;

class MyClass
{
    int x = 5, y = 0;

    public void Clac()
    {
        try{
            Console.WriteLine("{0}", x / y);
        }
        catch(DivideByZeroException d)
        {
            Console.WriteLine(d.Message);
            throw;
        }
    }
}

class MyClassB
{
    public static void Main()
    {
        MyClass mc = new MyClass();

        try
        {
            mc.Clac();
        }
        catch (DivideByZeroException d)
        {
            Console.WriteLine(d.TargetSite);
        }
    }
}