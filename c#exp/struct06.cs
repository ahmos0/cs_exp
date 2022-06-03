using System;

struct Mydata
{
    public int x, y;
}

class MyDataClass
{
    public int x, y;
}

class ChangeData
{
    public void Change(ref Mydata md)
    {
        int temp;
        temp = md.x;
        md.x = md.y;
        md.y = temp;
    }
    public void Change(Mydata md)
    {
        int temp;
        temp = md.x;
        md.x = md.y;
        md.y = temp;
    }
    public void Change(MyDataClass m)
    {
        int temp;
        temp = m.x;
        m.x = m.y;
        m.y = temp;
    }
}

class Struct06
{
    public static void Main()
    {
        Mydata md = new Mydata();
        md.x = 10;
        md.y = 20;

        Console.WriteLine("最初の状態");
        Console.WriteLine("md.x = {0}, md.y = {1}", md.x, md.y);

        ChangeData cd = new ChangeData();
        cd.Change(md);
        Console.WriteLine("cd.Change(md)後");
        Console.WriteLine("md.x = {0}, md.y = {1}", md.x, md.y);

        Mydata m;
        m.x = 10;
        m.y = 20;

        Console.WriteLine("最初の状態");
        Console.WriteLine("m.x = {0}, m.y = {1}", m.x, m.y);
        cd.Change(ref m);
        Console.WriteLine("cd.change(ref m)後");
        Console.WriteLine("m.x = {0}, m.y = {1}", m.x, m.y);

        MyDataClass mdc = new MyDataClass();
        mdc.x = 10;
        mdc.y = 20;
        Console.WriteLine("最初の状態");
        Console.WriteLine("mdc.x = {0}, mdc.y = {1}", mdc.x, mdc.y);
        cd.Change(mdc);
        Console.WriteLine("cd.Change(mdc)後");
        Console.WriteLine("mdc.x = {0}, mdc.y = {1}", mdc.x, mdc.y);
    }
}