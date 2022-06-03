using System;

class MyClass<T>
{
    public T name;
    public T GetVal()
    {
        return name;
    }
}

class Generic01
{
    public static void Main()
    {
        MyClass<int> mca = new MyClass<int>();
        mca.name = 10;
        Console.WriteLine(mca.GetVal());

        MyClass<string> mcb = new MyClass<string>();
        mcb.name = "猫ちゃん";
        Console.WriteLine(mcb.GetVal());
    }
}