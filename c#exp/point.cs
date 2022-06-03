using System;

class Point
{
    private int x, y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y; 
        Console.WriteLine("x = " + x + "y = " + y);
        Console.WriteLine("呼ばれた");
        Console.WriteLine(this.x + " " + this.y);
    }
    public void setX(int x)
    {
        Console.WriteLine("sX x = " + x + "y = " + y);
        this.x = x; 
        Console.WriteLine("sx"+ this.x + " " + this.y);
    }
    public void setY(int y)
    {
        Console.WriteLine("sY x = " + x + "y = " + y);
        this.y = y; 
        Console.WriteLine("sy"+ this.x + " " + this.y);
    }
    public int getX()
    {
        Console.WriteLine("gX x = " + x + "y = " + y);
        return x; 
        }
    public int getY()
    {
        Console.WriteLine("gX x = " + x + "y = " + y);
        return y; 
    }
}


public class ReferenceCall
{
    public void test()
    {
        Point point = new Point(8, 5);
        movePoint(point);
        int x = point.getX();
        int y = point.getY();
        Console.WriteLine("(x, y) = (" + x + ", " + y + ")");
    }
    private void movePoint(Point q)
    {
        q.setX(100);
        q.setY(120);

        q = new Point(0, 0);
        Console.WriteLine(q.getX() + "     " + q.getY());

    }
    public static void Main()
    {
        new ReferenceCall().test();
    }
}