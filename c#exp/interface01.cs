using System;

interface IMyInterface
{
    void Show(string str); //抽象メソッド
    int xprop{             //抽象プロパティ
        get;
        set;
    }

    int this[int i]{       //抽象インデクサinndekusa
        get;
        set;
    }
}

class Myclass : IMyInterface
{
    protected int i;
    int[] arr = new int[10];

    public void Show(string str)    //抽象メソッドの実装
    {
        Console.WriteLine(str);
    }
    public int xprop{               //抽象プロパティの実装
        get{
            return i;
        }
        set{
            i = value;
        }
    }
    
    public int this[int index]{
        get{
            return arr[index];
        }
        set{
            arr[index] = value;
        }
    }
}


class Interface01
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        mc.Show("Test Interface");
        mc.xprop = 100;
        Console.WriteLine("mc.xprop = {0}", mc.xprop);
        for(int i = 0; i < 10; i++)
        {
            mc[i] = i * 2;
        }
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("mc[{0}] = {1}", i, mc[i]);
        }
    }
}