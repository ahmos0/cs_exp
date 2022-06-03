using System;

class Myclass
{
    public Myclass m1, m2;
    
    public void Test()
    {
        m2 = this;
    }
    public Myclass()
    {
        m1 = this;
    }
    
}

class This01
{
   
    public static void Main()
    {
        Myclass mc = new Myclass();

        mc.Test();
        //Console.WriteLine(mc.m1);
        if(mc.m1 == mc.m2)
        {
            Console.WriteLine("m1とm2は同じです");
        }
        if(mc == mc.m1)
        {
            Console.WriteLine("mcとm1は同じです");
        }
        if(mc == mc.m2)
        {
            Console.WriteLine("mcとm2は同じです");
        }
    }
}
