using System;

class Myoverload
{
    int[] a = new int[3]{1, 2, 3};
    int[,] b = new int[2, 2]{{100, 200}, {300, 400}};

    //インデックスが１次元のインデクサ
    public int this[int i]
    {
        get{
            return a[i];
        }
    }
    //インデクサが二次元のインデクサ
    public int this [int i, int j]
    {
        get{
            return b[i, j];
        }
    }
}

class Indexer05
{
    public static void Main()
    {
        Myoverload mo = new Myoverload();

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                Console.WriteLine("mo[{0}, {1}] = {2}",i, j, mo[i, j]);
            }
        }
    }
}