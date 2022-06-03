using System;

class Average02
{
    public static void Main()
    {
        int[,] myarray = new int[2,3];
        int i = 0, j = 0;

        myarray[0,0] = 1;
        myarray[0,1] = 2;
        myarray[0,2] = 3;
        myarray[1,0] = 4;
        myarray[1,1] = 5; 
        myarray[1,2] = 6;

        for(i = 0; i < 2; i++)
        {
            for(j = 0; j < 3; j++)
            {
                Console.WriteLine("myarray[{0}, {1}] = {2}", i, j, myarray[i, j]);
            }
        }
    }
}