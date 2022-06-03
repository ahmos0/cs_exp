using System;

class Jyukenntensuu
{
    public static void Main()
    {
        int  numbers = 0, i = 0, sum = 0;
        double avg = 0;
        Console.WriteLine("人数を入力してください");
        numbers = int.Parse(Console.ReadLine());
        int[] person = new int[numbers];
        for(i = 0; i < numbers; i++)
        {
            Console.WriteLine("点数を入力して下さい");
            person[i] = int.Parse(Console.ReadLine());
            sum+=person[i];
        }
        avg = (double)sum/numbers;
        Console.WriteLine();
        Array.Sort(person);
        for(i = 0; i < numbers; i++)
        {
            Console.WriteLine(person[i]);
        }
    }
}