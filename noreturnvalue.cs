using System;

class kakeibo
{
    private int total = 0;

    public void Nyukin(int en)
    {
        total += en;
        Console.WriteLine("{0}円入金しました", en);
        return;
    }

    public void Shishutu(int en)
    {
        if(total < en)
        {
            Console.WriteLine("{0}円も支出できません", en);
            return;
        }
        else 
        {
            total -= en;
            Console.WriteLine("{0}円支出しました", en);
            return;
        }
    }

    public void Gettotal()
    {
        if(total == 0)
        {
            Console.WriteLine("残高はありません");
            return;
        }
        else 
        {
            Console.WriteLine("残高は{0}円です", total);
            return;
        }
    }
}

class NorRturnValue
{
    public static void Main()
    {
        kakeibo k = new kakeibo();

        k.Gettotal();
        k.Nyukin(1000);
        k.Gettotal();
        k.Nyukin(2000);
        k.Gettotal();
        k.Shishutu(500);
        k.Gettotal();
        k.Shishutu(10000);
        k.Gettotal();

    }
}