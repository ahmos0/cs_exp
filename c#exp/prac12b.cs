using System;

delegate int Per(int a, int b);

class EventClass
{
    public event Per OK;

    public int Keisann(int x, int y)
    {
        if(OK != null)
        {
            return OK(x, y);
        }
        return -1;
    }
}

class Mulitple
{
    public int Multi(int x, int y)
    {
        return x + y;
    }
    /*public int Decrease(int x, int y)
    {
        return x - y;
    }*/
}

class prac12
{
    public static void Main()
    {
        EventClass ec = new EventClass();
        Mulitple m = new Mulitple();
        ec.OK += new Per(m.Multi);
        //Per p1 = (a, b) => m.Multi(a,b);
        //Per p2 = (a, b) => m.Decrease(a, b);

        Console.WriteLine(ec.Keisann(10, 20));
        //Console.WriteLine(p2(10, 20));
    }
}