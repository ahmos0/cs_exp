using System.Net.Http;
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

class Complex : MyComplex
{
    public static Complex operator -(Complex c)
    {
        Complex result = new Complex();
        result.a = -1.0 * c.a;
        result.i = -1.0 * c.i;
        return result;
    }

    public Complex() : base(){}
    public Complex(double x, double y) : base(x, y){}
}

class Opov01
{
    public static void Main()
    {
        Complex A, B;

        A = new Complex(5, 2);
        B = new Complex(6, -3);

        Console.WriteLine("-Aの実部は{0}で虚部は{1}です", -A.a, -A.i);
        Console.WriteLine("-Bの実部は{0}で虚部は{1}です", -B.a, -B.i);
    }
}