using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge
{
    public class Shape : IShapeType
    {
        public Shapes.ShapeType type;

        public Shape(Shapes.ShapeType type)
        {
            this.type = type;
        }
    }
}
