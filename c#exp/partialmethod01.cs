using System;

partial class PartialMethod01
{
    public static void Main()
    {
        Console.WriteLine("Mainメソッドです");

        PartialMethod01 pm = new PartialMethod01();
        pm.Func1();
        pm.Func2("テスト");
    }
    //ここではメソッドの中身を記述していない
    //戻り値はvoid型,private型でなくてはだめ
    partial void Func1();
    partial void Func2(string s);
}

partial class PartialMethod01
{
    partial void Func1()
    {
        Console.WriteLine("パーシャルメソッド1です");
    }
}

partial class PartialMethod01
{
    partial void Func2(string s)
    {
        Console.WriteLine("引数は「{0}」です", s);
    }
}