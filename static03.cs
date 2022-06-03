using System;

class Cat
{
    static int numoftail;
    string name;

    public void SetName(string strName)
    {
        name = strName;
    }
    public void Showcat()
    {
        if(name == null)
        {
            Console.WriteLine("名前が設定されていません");
            return;
        }
        Console.WriteLine("猫の名前は{0}で尾の数は{1}本です", name, numoftail);
    }
    public static void SetCatTail(int num)
    {
        //ここではインスタンス変数にアクセスできない
        //name = "マイケル";
        numoftail = num;
    }
}

class Static03
{
    public static void Main()
    {
        Cat.SetCatTail(1);

        Cat myCat = new Cat();
        Cat yourCat = new Cat();

        myCat.Showcat();

        myCat.SetName("マイケル");
        yourCat.SetName("パトリシア");

        myCat.Showcat();
        yourCat.Showcat();
    }
}