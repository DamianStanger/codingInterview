namespace shapes
{
    public class Square : IShape
    {
        

        public Square(double width)
        {
            Area = width * width;
        }

        public double Area { get; private set; }
        public double Perimeter { get; private set; }
    }
}