using System;

delegate string MyDelegate(string a, string b);

class MyClass
{
    public static string Show(string s1, string s2)
    {
        return s1 + "は" + s2 + "です";
    }
}

class Delegate03
{
    public static void Main()
    {
        MyDelegate md = new MyDelegate(MyClass.Show);
        Console.WriteLine(md("C#", "面白い!!!"));
    }
}