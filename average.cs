using System;

class Average
{
    public static void Main()
    {
        int[] myarray = {70, 80, 50};
        int sum = 0, i = 0, no;
        double average = 0;

        no = myarray.Length;


        for(i = 0; i < no; i++)
        {
            sum += myarray[i];
        }
        average = (double)sum/no;
        Console.WriteLine("合計は{0}平均は{1:##.#}", sum, average);
    }
}