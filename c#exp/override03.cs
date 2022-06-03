using System;

class Mammal
{
    protected const int legNo = 4;

    public virtual string Nakigoe
    {
        get{
            return "...";
        }
    }

    public int Leg()
    {
        return legNo;
    }
}

class Cat : Mammal
{
    public override string Nakigoe
    {
        get{
            return "ニャー、ニャー";
        }
    }
}

class Dog : Mammal
{
    public override string Nakigoe
    {
        get{
            return "ワン、ワン";
        }
    }
}

class Override03
{
    public static void Main()
    {
        Mammal m;
        Cat cat = new Cat();
        Dog dog = new Dog();

        m = cat;
        Console.WriteLine("猫の脚の本数は{0}本で、鳴き声は「{1}」です", m.Leg(), m.Nakigoe);

        m = dog;
        Console.WriteLine("犬の脚の数は{0}本で、鳴き声は「{1}」です", m.Leg(), m.Nakigoe);
    }
}