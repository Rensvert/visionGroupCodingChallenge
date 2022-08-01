using System;
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
            // skip for now
        }

        public void CalculateArea()
        {
            var sqrt = Math.Sqrt(3) / 4;
            var localArea = sqrt * SideLength * SideLength;

            Area = Math.Round(localArea, SideLength.ToString().Length); // round to Sig Figs for a slightly more accurate result
        }

        public void CalculateCentroidX(IShape shape)
        {
            // skip for now
        }

        public void CalculatePerimeter()
        {
            var localPer = 3 * SideLength;
            Perimeter = Math.Round(localPer, SideLength.ToString().Length); // round to Sig Figs for a slightly more accurate result
        }
    }
}
