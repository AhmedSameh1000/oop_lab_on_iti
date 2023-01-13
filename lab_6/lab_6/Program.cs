using System;
public class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(3);
        Square square = new Square(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Shape[] All_shape = new Shape[] { circle, square, rectangle };
        for (int i = 0; i < All_shape.Length; i++)
        {
            All_shape[i].print();
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
abstract public class Shape
{
    protected int Dimension_1 { get; set; }
    protected virtual double CalcArea()
    {
        return 0;
    }
    public virtual void print()
    {
        Console.WriteLine("empty");
    }
}
public class Square: Shape
{
    public Square(int dimension_1=0)
    {
        this.Dimension_1 = dimension_1;
    }
    protected override double CalcArea()
    {
        return this.Dimension_1 * Dimension_1;
    }
    public override void print()
    {
        Console.WriteLine($"tha result of {nameof(Square)} is ({CalcArea()})");
    }
}
class Rectangle: Shape
{
    private int _dimension_2;
    public Rectangle(int dimension_1=0, int dimension_2=0)
    {
        this.Dimension_1 = dimension_1;
        this._dimension_2 = dimension_2;
    }
    protected override double CalcArea()
    {
        return this.Dimension_1 * this._dimension_2;
    }
    public override void print()
    {
        Console.WriteLine($"tha result of {nameof(Rectangle)} is ({CalcArea()})");
    }
}
class Circle : Shape
{
    public Circle(int dimension_1)
    {
        this.Dimension_1 = dimension_1;
    }
    protected override double CalcArea()
    {
        return 3.14 *this.Dimension_1 * this.Dimension_1;
    }
    public override void print()
    {
        Console.WriteLine($"tha result of {nameof(Circle)} is ({CalcArea()})");
    }

}