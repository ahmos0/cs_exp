using System;

interface IInterface1
{
    void SetDataNo(int n);
    void SetData(double data, int i);
    double CalcSum();
}

interface IInterface2 : IInterface1
{
    double CalcAverage();
}

class Myclass : IInterface2
{
    double[] data;
    bool bOK = false;


    public void SetDataNo(int n)
    {
        data = new double[n];
        bOK = true;
    }
    public void SetData(double d, int i)
    {
        if(!bOK)
        {
            Console.WriteLine("配列の準備ができていません");
            return;
        }
        data[i] = d;
    }
    public double CalcSum()
    {
        if(!bOK)
        {
            Console.WriteLine("配列の準備ができていません");
            return -1.0;
        }
        double sum = 0.0;
        for(int i = 0; i < data.Length; i++)
        {
            sum += data[i];
        }
        return sum;
    }
    public double CalcAverage()
    {
        double sum = CalcSum();
        return sum / data.Length;
    }
}

class Interface06
{
    public static void Main()
    {
        Myclass mc = new Myclass();
        int nNo;

        while(true)
        {
            Console.WriteLine("データ数---");
            string strNo = Console.ReadLine();
            nNo = Int32.Parse(strNo);
            mc.SetDataNo(nNo);


            for(int i = 0; i < nNo; i++)
            {
                Console.WriteLine("data[{0}] = ", i);
                string strData = Console.ReadLine();
                mc.SetData(double.Parse(strData), i);
            }
            Console.WriteLine("合計 = {0}", mc.CalcSum());
            Console.WriteLine("平均 = {0}", mc.CalcAverage());
            Console.WriteLine();
            Console.Write("続けますか(Y/N)---");
            string yn = Console.ReadLine();
            if(yn == "N" || yn == "n")
            {
                break;
            }
        }
    }
}