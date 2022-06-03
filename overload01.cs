using System;

class ManyMethods
{
    public int Method(int x)
    {
        Console.WriteLine("第一のバージョンが呼ばれました");
        return x + 10;
    }
    public double Method(double x)
    {
        Console.WriteLine("第二のバージョンが呼ばれました");
        return x * 2;
    }
    public string Method(string x)
    {
        Console.WriteLine("第三のバージョンが呼ばれました");
        return x += "です";
    }
    public int Method(int x, int y)
    {
        Console.WriteLine("第四のバージョンが呼ばれました");
        return x + y;
    }
}

class overload01
{
    public static void Main()
    {
        ManyMethods m = new ManyMethods();
        Console.WriteLine("その戻り値は「{0}」です", m.Method(3));
        Console.WriteLine("その戻り値は「{0}」です", m.Method(3.2));
        Console.WriteLine("その戻り値は「{0}」です", m.Method("濵田"));
        Console.WriteLine("その戻り値は「{0}」です", m.Method(5, 6));
    }
}