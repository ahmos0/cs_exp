using Cat;
using D = Dog;
namespace Cat
{
    using System;
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
    using System;
    class Animal
    {
        public string name;
        public void Show()
        {
            Console.WriteLine("犬の名前は{0}です", name);
        }
    }
}
namespace  MyNamespace
{
    class Namespace01
    {   
        public static void Main()
        {
            Animal cat = new Animal();
            cat.name = "タマ";

            D.Animal dog = new D.Animal();
            dog.name = "ポチ";

            cat.Show();
            dog.Show();
        }
    }
}

