using System;
using System.Collections.Generic;
using System.Text;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes.IndividualShapes
{
    public class Polygons : Shape, IShape
    {
        public Polygons(int Id) : base(Id)
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
