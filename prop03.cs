using System;

class Test
{
    static int x;
    
    public static int myProp
    {
        get{
            return x; //静的メンバxを返す
        }
        set{
            x = value;//静的メンバxに代入
            // value は　ユーザーが入力した値を示す特別な語（コンテキストキーワード）
        }
    }
}

class Prop03
{
    public static void Main()
    {
        Test.myProp = 10;
        Console.WriteLine("Test.myProp = {0}", Test.myProp);
    }
}