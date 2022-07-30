using System;
using System.Collections.Generic;
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

        public void CalculateCentroidY(IShape shape)
        {
        }

        public void CalculateArea(IShape shape)
        {
        }

        public void CalculateCentroidX(IShape shape)
        {
        }

        internal void PopulateXcords(string[] itemList)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter(IShape shape)
        {
        }


        public void PopulateXcords(List<string> lineList)
        {

        }

        public void PopulateYcords(string line)
        {

        }
    }
}
