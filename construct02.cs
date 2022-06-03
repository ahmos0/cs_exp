using System;

class Myclass
{
    private string name;
    private int age;
    private string address;

    public void Show()
    {
        string toshi;
        if(age == -1)
        {
            toshi = "不明";
        }
        else 
        {
            toshi = age.ToString();
        }

        Console.WriteLine("氏名:{0} 住所:{1} 年齢{2}", name, address, toshi);
    }
    
    public Myclass(string str)
    {
        name = str;
        address = "不定";
        age = -1;
    }

    public Myclass(int x)
    {
        age = x;
        name = "不明";
        address = "不定";
    }

    public Myclass(string str1, string str2, int x)
    {
        name = str1;
        address = str2;
        age = x;
    }

    class Construct02
    {
        public static void Main()
        {
            Myclass mc1 = new Myclass(18);
            Myclass mc2 = new Myclass("濵田翔真");
            Myclass mc3 = new Myclass("秋葉由人", "茨城県", 19);
            mc1.Show();
            mc2.Show();
            mc3.Show();
        }
    }
}