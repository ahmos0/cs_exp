using System;

class bmi
{
    public static void Main()
    {
        Console.WriteLine("身長を入力してください");
        double high = double.Parse(Console.ReadLine());
        Console.WriteLine("体重を入力してください");
        double wight = double.Parse(Console.ReadLine());
        double b = wight/Math.Pow(high,2.0);
        Console.WriteLine("BMI:{0:##.#}",b);
    }
}