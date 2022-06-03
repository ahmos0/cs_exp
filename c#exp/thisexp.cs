using System;

class Point
{
    private int x, y;
    
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void setX(int x)
    {
        this.x = x;
    }
    public void setY(int y)
    {
        this.y = y;
    }
    public int getX()
    {
        return x;
    }
    public int getY()
    {
        return y;
    }

}

class ReferenceCall
{
    public void test()
    {
        Point point = new Point(8, 5);

        movePoint(point);

        int x = point.getX();
        int y = point.getY();
        Console.WriteLine("(x, y) = " + "(" + x + "," + y + ")");
    }

    private void movePoint(Point p)
    {
        p.setX(100);
        p.setY(120);
    }
    public static void Main()
    {
        new ReferenceCall().test();
    }
}