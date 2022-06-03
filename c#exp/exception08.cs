using System;

class exception08
{
    public static void Main()
    {
        int x = 10, y = 0;

        try
        {
            try
            {
                Console.WriteLine("{0}", x / y);
                
            }
            catch(IndexOutOfRangeException i)
            {
                Console.WriteLine(i.Message);
            }
        }
        catch(DivideByZeroException d)
        {
            Console.WriteLine(d.Message);
        }
    }
}