using System;

class Myclass
{
    public int Add(int x, int y)
    {
        int z = 0;
        z = x + y;
        return z;
    }
    
    class Method01 
    {
        public static void Main()
        {
            Myclass a = new Myclass();
            int sum;
            sum = a.Add(100, 200);
            Console.WriteLine("sum = {0}", sum);
        }
    }
}