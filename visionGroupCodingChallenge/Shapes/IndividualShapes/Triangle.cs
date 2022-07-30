using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes
{
    public class Triangle : Shape, IShape
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double SideLength { get; set; }

        public Triangle(int Id) : base(Id)
        {
        }

        public void CalculateCentroidY(IShape shape)
        {
        }

        public void CalculateArea(IShape shape)
        {
        }

        public void CalculateCentroidX(IShape shape)
        {
        }

        public void CalculatePerimeter(IShape shape)
        {
        }
    }
}
