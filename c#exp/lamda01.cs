using System;

delegate void MyDelegate();

class Lamda01
{
    public static void Show()
    {
        Console.WriteLine("呼ばれました");
    }
    public static void Main()
    {
        Show();

        //デリゲートの作成
        MyDelegate md = () => Show();
        //デリゲートを通してShowメソッドを実行
        md();
    }
}