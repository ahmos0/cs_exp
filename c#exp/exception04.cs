using System;

class Exception04
{
    public static void Main()
    {
        int x = 10, y = 0;
        try
        {
            Console.WriteLine("{0] / {1} = {2} ", x, y, x / y);
        }
        catch(IndexOutOfRangeException io)
        {
            Console.WriteLine(io.Message);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("0で割んなアホか！！！");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}