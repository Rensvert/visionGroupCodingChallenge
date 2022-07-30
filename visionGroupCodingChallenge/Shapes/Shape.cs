using System.Collections.Generic;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge
{
    public class Shape
    {
        public Shapes.ShapeType type;

        public int Id { get; set; }

        public double Area { get; set; }
        public double Perimeter { get; set; }
        public double Radius;
        public double CentroidX { get; set; }
        public double CentroidY { get; set; }
     
        public double CenterX;
        public double CenterY;
        public double SideLength;
        public double Orientation;
        public double R1;
        public double R2;

        public List<double> XList;
        public List<double> YList;

        public Shape(int Id)
        {
            this.Id = Id;
        }

        public void CalculateArea(Shape shape)
        {

        }

    }
}
