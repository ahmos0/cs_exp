#define TEST
using Internal;

using System;

class Preprocess01
{
    public static void Main()
    {

#if TEST        
        Console.WriteLine("テストです");
#endif       


#if(TEST && TEST2)

        Console.WriteLine("ここは、TESTとTEST2が定義されていないとコンパイルされません");
#endif

#if(TEST || TEST2)
        Console.WriteLine("ここはTESTかTEST2が定義されていればコンパイルされます");
#endif

#if TEST2
        Console.WriteLine("ここは、TEST2が定義されているとコンパイルされます");
#endif
    }

}