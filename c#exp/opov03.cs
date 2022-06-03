using System.ComponentModel;
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

    public static bool operator ==(Complex x, Complex y)
    {
        if(x.a == y.a && x.i == y.i)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator !=(Complex x, Complex y)
    {
        if(x.a == y.a && x.i == y.i)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public static Complex Conj(Complex x)
    {
        Complex result = new Complex();
        result.a = x.a;
        result.i = -x.i;
        return result;
    }
    public static double Abs(Complex x)
    {
        double temp;
        temp = Math.Pow(x.a, 2.0) + Math.Pow(x.i, 2.0);
        return Math.Sqrt(temp);
    }
    public override bool Equals(object obj)
    {
        if(obj.GetType() != this.GetType())
        {
            return false;
        }
        Complex b = (Complex)obj;
        if(b.a == this.a && b.i == this.i)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override int GetHashCode()
    {
        return (a + i).GetHashCode()^(a - i).GetHashCode();
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
    public Complex() : base(){}
    public Complex(double x, double y) : base(x, y){}
}

class opov03
{
    public static void Main()
    {
        Complex A, B, C;
        A = new Complex(5, 2);
        B = new Complex(2, 10);
        C = new Complex(7, 12);

        Console.WriteLine("A = {0}", A.ToString());
        Console.WriteLine("B = {0}", B.ToString());
        Console.WriteLine("C = {0}", C.ToString());
        Console.WriteLine("-A = {0}", (-A).ToString());
        Console.WriteLine("Aの共役な複素数は{0}", Complex.Conj(A).ToString());
        Console.WriteLine("Aの絶対値は{0}", Complex.Abs(A));
        Console.WriteLine("Aの絶対値の2乗は{0}", Math.Pow(Complex.Abs(A), 2.0));
        Console.WriteLine("「A+BとCは等しい」は{0}", (A+B).Equals(C));
        Console.WriteLine("A * (Aの共役複素数)は{0}", (A*Complex.Conj(A)).ToString());
    }
}