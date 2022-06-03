using System;
using System.Collections;

class Arraylist01
{
    public static void Main()
    {
        bool bEnd = false;
        string strData;
        double sum = 0.0;

        ArrayList a1 = new ArrayList();

        while(true)
        {
            Console.WriteLine("データ(数値以外で終了)--");
            strData = Console.ReadLine();
            if(!Char.IsDigit(strData[0]) && strData[0] != '-')
            {
                bEnd = true;
            }
            else 
            {
                a1.Add(double.Parse(strData));
            }
            if(bEnd)
            {
                break;
            }
        }
        for(int i = 0; i < a1.Count; i++)
        {
            Console.WriteLine("Data[{0}] = {1}", i + 1, a1[i]);
            sum += (double)a1[i];
    
        }
        int count = a1.Count;
        double avr = sum/count;
        Console.WriteLine("データ個数 = {0}", count);
        Console.WriteLine("平均値 = {0}", avr);
    }
}