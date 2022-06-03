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
    public static Complex operator +(Complex x, Complex y)
    {
        Complex result = new Complex();
        result.a = x.a + y.a;
        result.i = x.i + y.i;
        return result;
    }
    public static Complex operator *(Complex x, Complex y)
    {
        Complex result = new Complex();
        result.a = x.a * y.a - x.i * y.i;
        result.i = x.i * y.a + x.a * y.i;
        return result;
    }

    public static Complex operator /(Complex x, Complex y)
    {
        Complex result = new Complex();
        result.a = (x.a * y.a + x.i * y.i)/(Math.Pow(y.a, 2.0)+Math.Pow(y.i, 2.0));
        result.i = (x.i * y.a - x.a * y.i)/(Math.Pow(y.a, 2.0)+Math.Pow(y.i, 2.0));
        return result;
    }
    public static Complex operator -(Complex x, Complex y)
    {
        Complex result = new Complex();
        result.a = x.a - y.a;
        result.i = x.i - y.i;
        return result;
    }

    public override string ToString()
    {
        string result;
        if(this.i > 0 && this.i != 1.0)
        {
            result = this.a + " + " + this.i + "i";
        }
        else if(this.i == 1.0)
        {
            result = this.a + "+ i";
        }
        else if(this.i < 0 && this.i != -1.0)
        {
            result = this.a + " - " + (this.i * -1.0) + "i";
        }
        else if(this.i == -1.0)
        {
            result = this.a + " - i";
        }
        else
        {
            result = (this.a).ToString();
        }
        return result;
    }
    public Complex() : base() {}
    public Complex(double x, double y) : base(x, y){}
}

class Opov02
{
    public static void Main()
    {
        Complex A, B, C, X, O;

        A = new Complex(5,2);
        B = new Complex(6,-3);
        C = new Complex(3,2);
        X = new Complex(1,0);
        O = new Complex();

        Console.WriteLine("A = {0}", A.ToString());
        Console.WriteLine("B = {0}", B.ToString());
        Console.WriteLine("X = {0}", X.ToString());
        Console.WriteLine("O = {0}", O.ToString());

        Console.WriteLine("A + 0 = {0}", (A + O).ToString());
        Console.WriteLine("A * 0 = {0}", (A * O).ToString());
        Console.WriteLine("A + B = {0}", (A + B).ToString());
        Console.WriteLine("B + A = {0}", (B + A).ToString());
        Console.WriteLine("A * B = {0}", (A * B).ToString());
        Console.WriteLine("B * A = {0}", (B * A).ToString());
        Console.WriteLine("A / B = {0}", (A / B).ToString());
        Console.WriteLine("B / A = {0}", (B / A).ToString());
        Console.WriteLine("(A / B) * (B / A) = {0}", ((A / B) * (B / A)).ToString());
        Console.WriteLine("(X / A) = {0}", (X / A).ToString());
        Console.WriteLine("(X / A) * A = {0}", ((X / A) * A).ToString());
        Console.WriteLine("A * (B + C) = {0}", (A * (B + C)).ToString());
        Console.WriteLine("A * B + A * C = {0}", (A * B + A * C).ToString());

    }
}