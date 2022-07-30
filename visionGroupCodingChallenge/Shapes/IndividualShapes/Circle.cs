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

        public void CalculateArea(Shape shape)
        {
            throw new NotImplementedException();
        }

        public void CalculateCentroidX(Shape shape)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter(Shape shape)
        {
            throw new NotImplementedException();
        }
    }
}
