using System;

class Myclass
{
    public void Show(params string[] animal)
    {
        if(animal.Length == 0)
        {
            return;
        }
        for(int i = 0; i <  animal.Length; i++)
        {
            Console.WriteLine("{0}さんがいます", animal[i]);
        }
    }
}

class params01
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        mc.Show();
        mc.Show("きりん", "ぞう", "かば");
    }
}