using System;

class MyComplex
{
    double real;
    double imaginary;

    public double a
    {
        get
        {
            return real;
        }
        set
        {
            real = value;
        }
    }

    public double i
    {
        get
        {
            return imaginary;
        }
        set
        {
            imaginary = value;
        }
    }

    public MyComplex()
    {
        real = 0.0;
        imaginary = 0.0;
    }

    public MyComplex(double x, double y)
    {
        real = x;
        imaginary = y;
    }
}

class Complex01
{
    public static void Main()
    {
        MyComplex A = new MyComplex();
        A.a = 10;
        A.i = 5;

        MyComplex B = new MyComplex(2,3);

        Console.WriteLine("複素数Aの実部は{0}で虚部は{1}です", A.a, A.i);
        Console.WriteLine("複素数Bの実部は{0}で虚部は{1}です", B.a, B.i);
    }
}