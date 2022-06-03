using System;

namespace Cat
{
    class Animal
    {
        public string name;
        public void Show()
        {
            Console.WriteLine("猫の名前は{0}です", name);
        }
    }
}

namespace Dog
{
    class Animal
    {
        public string name;
        public void Show()
        {
            Console.WriteLine("犬の名前は{0}です", name);
        }
    }
}

class Namespace01
{
    public static void Main()
    {
        Cat.Animal cat = new Cat.Animal();
        cat.name = "タマ";

        Dog.Animal dog = new Dog.Animal();
        dog.name = "ポチ";

        cat.Show();
        dog.Show();
    }
}