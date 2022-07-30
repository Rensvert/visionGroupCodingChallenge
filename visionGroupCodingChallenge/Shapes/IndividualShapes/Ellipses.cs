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
            // Not Yet
        }

        public void CalculateArea(IShape shape)
        {
            var tempArea = Math.PI * R1 * R2;
            Area = Math.Round(tempArea, R1.ToString().Length); // round to Sig Figs for a slightly more accurate result
        }

        public void CalculateCentroidX(IShape shape)
        {
            // Not yet
        }

        public void CalculatePerimeter(IShape shape)
        {
            // This forumla is sorta a mess I believe my Calculation is off a bit, from a rounding error somewhere.

            var StartingPoint = Math.PI * (R1 + R2);

            // need the value of (A-B)^2
            var squaredMin = Math.Pow(R1 - R2, 2);

            // need the value of (A+B)^2
            var squaredMax = Math.Pow(R1 + R2, 2);

            var h = squaredMin / squaredMax;
           
            var sqrt = Math.Sqrt(4- (3*h));

            var tempPer = StartingPoint * (1 + (3 * h) / (10 + sqrt));

            Perimeter = Math.Round(tempPer, R1.ToString().Length);



        }
    }
}
