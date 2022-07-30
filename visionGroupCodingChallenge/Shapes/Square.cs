using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes
{
    public class Square : Shape, IShape
    {
        public Square(int Id) : base(Id)
        {
        }

        public void CalculateArea(Shape shape)
        {
            throw new System.NotImplementedException();
        }
    }
}
