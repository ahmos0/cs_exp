using System;

delegate void MyDelegate();

class Delegate01
{
    static void Show()
    {
        Console.WriteLine("呼ばれました");
    }

    public static int Main()
    {
        Show();

        MyDelegate md = new MyDelegate(Show);

        md();

        return 0;
    }
}