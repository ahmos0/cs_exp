using System;

class MyIndexer
{
    int[] array;
    int nMax; //配列の要素数

    public int this[int n]
    {
        get{
            if(n < nMax) //インデックスnをチェック
            {
                return array[n];
            }
            else
            {
                return 0;
            }
        }
        set{
            if(n < nMax)
            {
                array[n] = value;
            }
        }
    }

    public MyIndexer(int i) //コンストラクタ
    {
        array = new int[i]; //要素数iの配列を生成
        nMax = i; //配列の要素数を設定
    }
}

class Indexer02
{
    public static void Main()
    {
        int i = 0;
        MyIndexer mi = new MyIndexer(20);

        for(i = 0; i < 20; i++)
        {
            mi[i] = i * i;
        }
        for(i = 0; i < 20; i++)
        {
            Console.WriteLine("{0} * {0} = {1}", i, mi[i]);
        }

        mi[30] = 30;
        Console.WriteLine("mi[30] = {0}", mi[30]);
    }
}