using System;

class array03
{
    public static void Main()
    {
        string[,] Name = new string[2,5]
        {
            {"濵田翔真","秋葉由人","塩入健矢", "大和田将矢","三浦空澄"},
            {"櫻井翔","若生優希","對馬麦","渡部真希","伊藤誠哉"}
        };
        int myClass, num;
        string strClass, strNum;

        while(true)
        {
            Console.Write("クラス---");
            strClass = Console.ReadLine();
            if(strClass.Length >= 2)
            {
                Console.WriteLine("入力は1桁のみです");
                continue;
            }
            if(Char.IsNumber(strClass, 0) != true)
            {
                Console.WriteLine("数字を入力して下さい");
                continue;
            }
            myClass = Int32.Parse(strClass);
            if(myClass <= 0 || myClass >= 3)
            {
                Console.WriteLine("クラスは1組か2組です");
                continue;
            }
            break;
        }
        while(true)
        {
            Console.Write("出席番号は---");
            strNum = Console.ReadLine();

            if(strNum.Length >= 2)
            {
                Console.WriteLine("入力は1桁のみです");
                continue;
            }
            if(Char.IsNumber(strNum, 0)!= true)
            {
                Console.WriteLine("数字を入力して下さい");
                continue;
            }

            num = Int32.Parse(strNum);

            if(num <= 0 || num >= 6)
            {
                Console.WriteLine("出席番号は1番から5番までです");
                continue;
            }
            break;
        }

        Console.WriteLine("{0}クラスの出席番号{1}番は{2}さんです", strClass, strNum, Name[myClass -1, num - 1]);


    }
}