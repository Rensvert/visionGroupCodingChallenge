using System;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes
{
    public class Circle : Shape, IShape
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double Radius { get; set; }

        public Circle(int Id) : base(Id)
        {
        }

        public void CalculateCentroidY(IShape shape)
        {
            CentroidY = CenterY;
        }

        public void CalculateArea()
        {
            var radiusSquared = Math.PI * Radius * Radius;
            Area = Math.Round(radiusSquared, 11);
        }

        public void CalculateCentroidX(IShape shape)
        {
            CentroidX = CenterX;
        }

        public void CalculatePerimeter()
        {
            var circumfrence = Radius * 2 * Math.PI;
            Perimeter = Math.Round(circumfrence, 11);
        }
    }
}
