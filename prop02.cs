using System;

class BMI
{
    double bw, bl;

    public double blprop
    {
        //身長を返すプロパティ
        get{
            return bl;
        }
        set{
            if(value <= 0)
            {
                Console.Write("身長に0または負の値は設定できません");
                return;
            }
            bl = value;
        }
    }

    public double bwprop
    {
        get{
            return bw;
        }
        set{
            if(value <= 0)
            {
                Console.Write("体重に0または負の値は設定できません");
                return;
            }
            bw = value;
        }
    }

    public double CalcBMI()
    {
        if(bl == 0.0 || bw == 0.0)
        {
            Console.WriteLine("データがセットされていません");
            return 0.0;
        }
        return bw / Math.Pow(bl, 2.0);
    }
}

class Prop2
{
    public static void Main()
    {
        BMI myBmi = new BMI();
        double bl;
        double bw;

        do{
            Console.WriteLine("身長(m)---");
            string strBl = Console.ReadLine();
            bl = double.Parse(strBl);
            myBmi.blprop = bl;
        }while(bl <= 0.0);

        do{
            Console.Write("体重(kg)---");
            string strBw = Console.ReadLine();
            bw = double.Parse(strBw);
            myBmi.bwprop = bw;
        }while(bw <= 0.0);

        Console.WriteLine("b1 = {0}, bw = {1}", myBmi.blprop, myBmi.bwprop);

        Console.WriteLine("BMI = {0:#.#}", myBmi.CalcBMI());
    }
}