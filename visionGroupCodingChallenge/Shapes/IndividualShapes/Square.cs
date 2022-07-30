using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes
{
    public class Square : Shape, IShape
    {

        public Square(int Id) : base(Id)
        {
        }

        public void CalculatCentroidY(Shape shape)
        {
            throw new System.NotImplementedException();
        }

        public void CalculateArea(double number)
        {
        }

        public void CalculateCentroidX(Shape shape)
        {
            throw new System.NotImplementedException();
        }

        public void CalculatePerimeter(IShape shape)
        {
        }
    }
}
