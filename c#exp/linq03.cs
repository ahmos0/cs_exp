using System;
using System.Collections.Generic;
using System.Linq;

class Data
{
    public string name;
    public string address;
    public int age;
}

class Linq03
{
    public static void Main()
    {
        List<Data> myData = new List<Data>{
            new Data{
                name = "田中",
                address = "東京",
                age = 24},
            new Data{
                name = "怒",
                address = "西京",
                age = 28},
            new Data{
                name = "喜",
                address = "北京",
                age = 999},
            new Data{
                name = "哀",
                address = "南京",
                age = 24},
            new Data{
                name = "楽",
                address = "中京",
                age = 32}
        };

        //旧式のデータ追加
        Data datax = new Data();
        datax.name = "濵田症";
        datax.address = "京都";
        datax.age = 20;
        myData.Add(datax);
        //新方式のデータ追加
        myData.Add(new Data
        {
            name = "ジジイかいババアかい",
            address = "まだ見ぬ未踏のち",
            age = 99999
        });
        
        var q = 
            from x in myData
            where x.age < 100
            orderby x.age ascending
            select x;
        
        Console.WriteLine("氏名\t\t住所\t年齢");
        foreach (Data z in q)
        {
            Console.WriteLine("{0}\t{1}\t{2}", z.name, z.address, z.age);
        }
    }
}