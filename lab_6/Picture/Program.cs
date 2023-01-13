using System;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        Square square= new Square(5);
        Rectangle rectangle =new Rectangle(2,3);
        Circle circle= new Circle(40);
        Picture picture = new Picture();

        picture .Square_prop = square;

        picture.rectangle_prop = rectangle;
        Console.WriteLine   ($"total Area {picture.get_totla_area()}");
        picture.print_circle_area(circle);
    }
}
class Picture
{             
    Square S1;
    Rectangle r2;
    public Square Square_prop 
    {
        set { S1 = new Square(value); }
        get { return new Square(S1); } 
    }

    public Rectangle rectangle_prop { get;set; }

    public Picture()
    {
        S1 = new Square();
        r2 = new Rectangle();
    }
    public Picture(Square square,Rectangle rectangle)
    {
        this.Square_prop = square;
        this.rectangle_prop = rectangle;
    }
    public  double get_totla_area()
    {
        return Square_prop.CalcArea()+ rectangle_prop.CalcArea();
    }
    public void print_circle_area(Circle circle)
    {
        double Area_of_circle= 3.14 * circle.Dimension_1 * circle.Dimension_1;
        Console.WriteLine($"Areaa circle =>> {Area_of_circle}");
    }
}

class Square
{
    private int Dimension_1;
    public Square(int dimension_1 = 1)
    {
        this.Dimension_1 = dimension_1;
    }
    public double CalcArea()
    {
        return Dimension_1 * Dimension_1;
    }
    public Square(Square square) : this(square.Dimension_1) { }
}
class Rectangle
{
    public int _dimension_2;
    public int _dimension_1;
    public Rectangle(int dimension_1 = 0, int dimension_2 = 0)
    {
        this._dimension_1 = dimension_1;
        this._dimension_2 = dimension_2;
    }
    public double CalcArea()
    {
        return this._dimension_1 * this._dimension_2;
    }
}
class Circle
{
    public int Dimension_1;
    public Circle(int dimension_1=1)
    {
        this.Dimension_1 = dimension_1;
    }
    public Circle(Circle circle):this(circle.Dimension_1){ }
}

