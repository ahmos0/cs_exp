using System;

class Myclass
{
    double bl;
    public double blprop
    {
        get{
            return bl;
        }
        set{
            bl = value;
        }
    }
}

class prop01
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        mc.blprop = 165.2;
        Console.WriteLine("bl = {0}", mc.blprop);
    }
}