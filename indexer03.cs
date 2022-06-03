using System;

class MyIndexer
{
    string[] mon = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};


    public int this[string monthName]
    {
        get{
            for(int i = 0; i < 12; i++)
            {
                if(monthName == mon[i])
                {
                    return i + 1;
                }
            }
            return 0;
        }
    }
}

class Indexer03
{
    public static void Main()
    {
        MyIndexer mi = new MyIndexer();
        Console.WriteLine("Mayは{0}番目の月です", mi["May"]);
        Console.WriteLine("Decは{0}番目の月です", mi["Dec"]);
        Console.WriteLine("xは{0}番目の月です", mi["x"]);
    }
}