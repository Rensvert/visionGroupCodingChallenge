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
            // not yet
        }

        public void CalculateArea()
        {
            var j = XList.Count - 1;

            if (j <= 0)
            {
                return;
            }

            double tempArea = 0.0;

            for (int i = 0; i < XList.Count; i++)
            {
                tempArea += (XList[j] + XList[i]) * (YList[j] - YList[i]);
                j = i;
            }

            Area = Math.Abs(Math.Round(tempArea / 2, XList[0].ToString().Length));
        }

        public void CalculateCentroidX(IShape shape)
        {
            // not yet
        }

        internal void PopulateXcords(string[] itemList)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            var j = XList.Count - 1;

            if (j <= 0)
            {
                return;
            }

            double tempPerm = 0.0;

            for (int i = 0; i < XList.Count; i++)
            {
                var xSquare = Math.Pow(XList[j] - XList[i], 2);
                var ySquare = Math.Pow(YList[j] - YList[i], 2);

                tempPerm += Math.Sqrt(xSquare + ySquare);
                j = i;
            }

            Perimeter = Math.Abs(Math.Round(tempPerm, XList[0].ToString().Length));
        }

    }
}
