using System;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes
{
    public class Ellipses : Shape, IShape
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double R1 { get; set; }
        public double R2 { get; set; }
        public Ellipses(int Id) : base(Id)
        {
        }

        public void CalculateCentroidY(IShape shape)
        {
        }

        public void CalculateArea(IShape shape)
        {
            var tempArea = Math.PI * R1 * R2;
            Area = Math.Round(tempArea, R1.ToString().Length); // round to Sig Figs for a slightly more accurate result
        }

        public void CalculateCentroidX(IShape shape)
        {
        }

        public void CalculatePerimeter(IShape shape)
        {
        }
    }
}
