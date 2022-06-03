using System;

class Myclass
{
    string[] name = new string[5];

    public string this[int i]
    {
        get{
            return name[i];
        }
        set{
           name[i] = value;
        }
    }
}


class Indexer01
{
    public static void Main()
    {
        Myclass mc = new Myclass();

        mc[0] = "ラプラス";
        mc[1] = "風間";
        mc[2] = "さかまた";
        mc[3] = "ルイ姉"; 
        mc[4] = "こより";

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(mc[i]);
        }
    }
}