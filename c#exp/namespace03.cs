namespace Animal
{
    using System;

    namespace Mammal
    {
        namespace Cat
        {
            class Cat
            {
                public string name;
                public void Show()
                {
                    Console.WriteLine("猫の名前は{0}です", name);
                }
            }
        }
    }
}

namespace MyNamespace
{
    class Namespace03
    {
        public static void Main()
        {
            Animal.Mammal.Cat.Cat myCat = new Animal.Mammal.Cat.Cat();
            myCat.name = "マイケル";
            myCat.Show();
            Animal.Dog myDog = new Animal.Dog();
            myDog.name = "ポチ";
            myDog.Show();
        }
    }
}

namespace Animal
{
    class Dog
    {
        public string name;
        public void Show()
        {
            System.Console.WriteLine("犬の名前は{0}です", name);
        }
    }
}