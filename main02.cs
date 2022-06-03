using System;

class Main02
{
    public static int Main(string[] args)
    {
        if(args.Length != 1)
        {
            return -1;
        }
        else 
        {
            if(!Char.IsDigit(args[0][0]))
            {
                return -2;
            }
        }
        return int.Parse(args[0]);
    }
}