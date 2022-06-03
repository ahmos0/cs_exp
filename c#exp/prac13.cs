using System;

class Prac13
{
    public static void Main()
    {
        byte x = 1, i = 1;
        while(true)
        {
            try
            {
                checked
                {
                    x *= (i++);
                }
                Console.WriteLine(x);
            }
            catch(OverflowException o)
            {
                Console.WriteLine(o.Message);
                break;
            }
        }
    }
}