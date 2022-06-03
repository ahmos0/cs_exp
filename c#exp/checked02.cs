using System;

class Checked02
{
    public static void Main()
    {
        int x, y, z;

        try
        {
            checked
            {
                x = int.MaxValue;
                y = 1;
                z = x + y;
                Console.WriteLine(z);
            }
        }
        catch(OverflowException o)
        {
            Console.WriteLine(o.Message);
            Console.WriteLine(o.StackTrace);
        }
    }
}