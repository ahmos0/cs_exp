using System;

class Myclass
{
    string[,] name;

    public string this[int i, int j]
    {
        get{
            return name[i, j];
        }
    }
    
    public Myclass()
    {
        name = new string[,]{
            {"田中", "佐藤", "吉田", "加藤", "久米"},
            {"工藤", "竹中", "斉藤", "太田", "杉本"}
        };
    }
}

class Indexer04
{
    public static void Main()
    {
        int i = 0, j = 0;
        Myclass mc = new Myclass();
        for(i = 0; i < 2; i++)
        {
            for(j = 0; j < 5; j++)
            {
                Console.WriteLine("{0}組{1}番--{2}", i + 1, j + 1, mc[i, j]);
            }
        }
    }
}