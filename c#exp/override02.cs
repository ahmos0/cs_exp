using System;

class Mamma1
{
    protected const int legNo = 4;
    protected string koe;

    public virtual string Nakigoe()
    {
        koe = "...";
        return koe;
    }
    public int Leg()
    {
        return legNo;
    }
}

class Cat : Mamma1
{
    public override string Nakigoe()
    {
        koe = "ニャー、ニャー";
        return koe;
    }
}

class Dog : Mamma1
{
    public override string Nakigoe()
    {
        koe = "ワン、ワン";
        return koe;
    }
}

class Overridee02
{
    public static void Main()
    {
        Mamma1 m;
        Cat cat = new Cat();
        Dog dog = new Dog();

        m = cat;
        Console.WriteLine("猫の脚は{0}本で鳴き声は「{1}」です", m.Leg(), m.Nakigoe());

        m = dog;
        Console.WriteLine("犬の脚は{0}本で鳴き声は「{1}」です", m.Leg(), m.Nakigoe());
    }
}