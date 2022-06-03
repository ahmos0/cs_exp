using System;

class Myclass
{
    int x;

    public void ShowX()
    {
        Console.WriteLine("x = " + x);
    }
        //コンストラクタ:クラスと同じ名前,戻り値の型はなし
    public Myclass()
    {
        x = 10;
        Console.WriteLine("xに10を代入しました");
        
    }

}

class Construct01
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        mc.ShowX();
    }
}