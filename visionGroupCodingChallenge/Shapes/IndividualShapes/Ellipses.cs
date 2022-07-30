using System;
using System.Collections.Generic;
using System.Text;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes
{
    public class Ellipses : Shape, IShape
    {
        public Ellipses(int Id) : base(Id)
        {
        }

        public void CalculatCentroidY(Shape shape)
        {
            throw new NotImplementedException();
        }

        public void CalculateArea(double number)
        {
            
        }

        public void CalculateCentroidX(Shape shape)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter(IShape shape)
        {
        }
    }
}
