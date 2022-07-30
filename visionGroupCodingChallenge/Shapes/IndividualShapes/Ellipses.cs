using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes
{
    public class Ellipses : Shape, IShape
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public Ellipses(int Id) : base(Id)
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
