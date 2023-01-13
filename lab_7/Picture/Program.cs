using System;
using ahmed;

class Program
{
    static void Main()
    {
        #region 1D_Array
        //Square square = new Square(4);
        //Circle circle = new Circle(6);
        //Rectangle rectangle = new Rectangle(3, 6);
        //Shape[] All_shaps = { square, circle, rectangle };
        //Picture_1D_Array picture = new Picture_1D_Array();
        //picture.Shapes = All_shaps;
        //double result = picture.calc_totla_Area();
        //Console.WriteLine($"The Result Of Shaps =>>{result}");
        #endregion
        #region 2D_Array
        //// -------------------------------------------------
        //Square square_1 = new Square(7);
        //Square square_2 = new Square(4);
        //Square square_3 = new Square(6);
        ////-------------------------------------------------
        //Circle circle_1 = new Circle(3);
        //Circle circle_2 = new Circle(7);
        //Circle circle_3 = new Circle(5);
        ////-------------------------------------------------
        //Rectangle rectangle_1 = new Rectangle(6, 4);
        //Rectangle rectangle_2 = new Rectangle(7, 3);
        //Rectangle rectangle_3 = new Rectangle(10, 5);
        ////-------------------------------------------------
        //Shape[,] All_shaps =
        //{
        //    {square_1,square_1,square_3},
        //    {circle_1,circle_2,circle_3},
        //    {rectangle_1,rectangle_2,rectangle_3}
        //};
        //Picture_2D_Array picture = new Picture_2D_Array();
        //picture.Shapes = All_shaps;
        //double[] result = picture.calc_totla_Area();
        //Console.WriteLine("-----------------------------------");
        //Console.WriteLine($"the result Of All shapes =>>{result[0] + result[1] + result[2]}");

        ////---------------------------------------------------
        #endregion
    }
}
class Picture_1D_Array
{
    public Shape[]? Shapes { get; set; }
    public double calc_totla_Area()
    {
        double sum = 0;
        for (int i = 0; i < Shapes!.Length; i++)
        {
            sum += Shapes[i].CalcArea();
        }
        return sum;
    }
}
class Picture_2D_Array
{
    public Shape[,]? Shapes { get; set; }
    public double[] calc_totla_Area()
    {
        double[]sum=new double[Shapes!.GetLength(0)];
        for (int r = 0; r < Shapes.GetLength(0); r++)
        {
            for (int c = 0; c < Shapes.GetLength(1); c++)
            {
                sum[r]+= Shapes[r, c].CalcArea();
            }
            Console.WriteLine($"the result of row {r} =>> {sum[r]}");
        }

        return sum;
    }
}