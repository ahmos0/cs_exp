using System;
using System.Collections.Generic;

class List01
{
    public static void Main()
    {
        bool bEnd = false;
        List<int> myList = new List<int>();

        while(true)
        {
            Console.Write("Data = ");
            string strData = Console.ReadLine();
            if(!Char.IsDigit(strData[0]))
            {
                bEnd = true;
            }
            else
            {
                myList.Add(int.Parse(strData));
            }
            if(bEnd)
            {
                break;
            }
        }
        Console.WriteLine();
        for(int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine("[{0}] {1}", i, myList[i]);
        }
        Console.WriteLine();
        myList.Sort();

        for(int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine("[{0}] {1}", i, myList[i]);
        }
    }
}