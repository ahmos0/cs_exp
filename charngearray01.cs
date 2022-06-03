using System;

class Change 
{
    public void Modify(int[] array)
    {
        int n = array.Length;
        int i = 0;
        for(i = 0; i < n; i++)
        {
            array[i] *= 2; //オブジェクトそのものを変更
        }
    }
}

class ChangeArray01
{
    public static void Main()
    {
        Change c = new Change();
        int[] myArray = new int[3]{1, 2, 3};

        Console.WriteLine("----Modifyメソッド実行前---");
        int i = 0;
        foreach(int x in myArray)
        {
            Console.WriteLine("myArray[{0}] = {1}", i, x);
            i++;
        }

        c.Modify(myArray);

        Console.WriteLine("---Modifyメソッド実行後---");
        i = 0;
        foreach(int x in myArray)
        {
            Console.WriteLine("myArray[{0}] = {1}", i, x);
            i++;
        }
    }
}