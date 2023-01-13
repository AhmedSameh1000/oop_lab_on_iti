using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        //--------------------------------------------------------------
        Square S1 = new Square(5);
        Square S2 = new Square(3);
        Square S3 = new Square(2);
        Square S4 = new Square(4);
        Square[]Arr_Of_squares=new Square[] {S1,S2,S3, S4 };
        //--------------------------------------------------------------
        Rectangle r1 = new Rectangle(7,3);
        Rectangle r2 = new Rectangle(6,4);
        Rectangle r3 = new Rectangle(2,5);
        Rectangle r4 = new Rectangle(5,3);
        Rectangle[] Arr_Of_rectangles = new Rectangle[] {r1,r2,r3,r4};
        //--------------------------------------------------------------
        Picture picture = new Picture();
        picture.Square_prop = Arr_Of_squares;
        picture.rectangle_prop = Arr_Of_rectangles;
        Console.WriteLine($"Total Area Of Squar And Rectangle {picture.get_totla_area()}");
        //---------------------------------------------------------------
        Console.WriteLine("--------------------------------------");
        Circle circle = new Circle(5);
        picture.print_circle_area(circle);
        //--------------------------------------------------------------
    }
}
class Picture
{
    Square[] S1=new Square[4];
    public Square[] Square_prop
    {
        set 
        {
            for (int i = 0; i < S1.Length; i++)
            {
                this.S1[i] = new Square(value[i]);
            }
        }
        get
        {
            return this.S1;
        }
    }
   
    public Rectangle[] rectangle_prop { get; set; }
    public Picture(Square[] squares, Rectangle[]rectangles )
    {
        this.Square_prop = squares;
        this.rectangle_prop = rectangles;
    }
    public Picture()
    {

    }
    public double get_totla_area()
    {
        double sum = 0;
        for (int i = 0; i < Square_prop.Length; i++)
        {
           sum+= Square_prop[i].CalcArea() + rectangle_prop[i].CalcArea();
        }
        return sum;
    }
    public void print_circle_area(Circle circle)
    {
        double Area_of_circle = 3.14 * circle.Dimension_1 * circle.Dimension_1;
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
    private int _dimension_2;
    private int _dimension_1;
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
    public Circle(int dimension_1 = 1)
    {
        this.Dimension_1 = dimension_1;
    }
    public Circle(Circle circle) : this(circle.Dimension_1) { }
}

