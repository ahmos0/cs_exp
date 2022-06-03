using System;

class Myclass
{
    double x;
    public double prop1
    {
        get{
            return x;
        }
        set{
            if(value <= 0)
            {
                return;
            }
            x = value;
        }
    }
}

class Prop
{
    public static void Main()
    {
        Myclass mc = new Myclass();

        string unko = Console.ReadLine();
        double m = double.Parse(unko);
        mc.prop1 = m;

        Console.WriteLine(unko);
    }
}