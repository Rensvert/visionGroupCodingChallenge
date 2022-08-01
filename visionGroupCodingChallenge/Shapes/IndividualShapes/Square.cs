using System;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes
{
    public class Square : Shape, IShape
    {
        public double SideLength { get; set; }
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public Square(int Id) : base(Id)
        {
        }

        public void CalculateCentroidY(IShape shape)
        {
            // skip for now
        }

        public void CalculateArea()
        {
            var localArea = SideLength * SideLength;
            Area = Math.Round(localArea, SideLength.ToString().Length);
        }

        public void CalculateCentroidX(IShape shape)
        {
            // Skip for now
        }

        public void CalculatePerimeter()
        {
            var localPerimeter = SideLength * 4;
            Perimeter = Math.Round(localPerimeter, SideLength.ToString().Length);
        }
    }
}
