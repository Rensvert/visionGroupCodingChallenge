using System;
using System.Collections.Generic;
using System.Text;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes
{
    public class Circle : Shape, IShape
    {
        public Circle(int Id) : base(Id)
        {
        }

        public void CalculatCentroidY(Shape shape)
        {
            throw new NotImplementedException();
        }

        public void CalculateArea(double number)
        {
            var radiusSquared = Math.PI * number * number;
            Area = Math.Round(radiusSquared, 11);
        }

        public void CalculateCentroidX(Shape shape)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter(IShape shape)
        {
            var circumfrence = shape.Radius * 2 * Math.PI;
            Perimeter = Math.Round(circumfrence, 11);
        }
    }
}
