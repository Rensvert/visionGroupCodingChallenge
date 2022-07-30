using System;
using System.Collections.Generic;
using System.Text;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes.IndividualShapes
{
    public class Polygons : Shape, IShape
    {
        public List<double> XList;
        public List<double> YList;

        public Polygons(int Id) : base(Id)
        {
            XList = new List<double>();
            YList = new List<double>();
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

        internal void PopulateXcords(string[] itemList)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter(Shape shape)
        {
            throw new NotImplementedException();
        }


        public void PopulateXcords(List<string> lineList)
        {

        }

        public void PopulateYcords(string line)
        {

        }
    }
}
