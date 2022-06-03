using System;

abstract class MyAb
{
    //Hanbetsuメソッドは抽象メソッド
    public abstract double Hanbetsu(double a, double b, double c);
}

class MyHanbetsu : MyAb
{
    //基本クラスの抽象メソッドは必ずオーバーライドする
    //このクラスでオーバーライドしない場合
    //このクラス自身も抽象クラスになる
    public override double Hanbetsu(double a, double b, double c)
    {
        return Math.Pow(b, 2.0) - 4.0 * a * c;
    }
}


class Abstract01
{
    public static void Main()
    {
        MyHanbetsu h = new MyHanbetsu();
        double d = h.Hanbetsu(1.0, 2.0, 3.0);
        Console.WriteLine(d);
    }
}