namespace ahmed
{
    abstract public class Shape
    {
        protected int Dimension_1 { get; set; }
        public abstract double CalcArea();
    }
    public class Square : Shape
    {
        public Square(int dimension_1 = 0)
        {
            this.Dimension_1 = dimension_1;
        }
        public override double CalcArea()
        {
            return this.Dimension_1 * Dimension_1;
        }
    }
    public class Rectangle : Shape
    {
        private int _dimension_2;
        public Rectangle(int dimension_1 = 0, int dimension_2 = 0)
        {
            this.Dimension_1 = dimension_1;
            this._dimension_2 = dimension_2;
        }
        public override double CalcArea()
        {
            return this.Dimension_1 * this._dimension_2;
        }
    }
    public class Circle : Shape
    {
        public Circle(int dimension_1)
        {
            this.Dimension_1 = dimension_1;
        }
        public override double CalcArea()
        {
            return 3.14 * this.Dimension_1 * this.Dimension_1;
        }
    }
}