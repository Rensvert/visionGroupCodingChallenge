﻿using CsvHelper.Configuration.Attributes;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge
{
    public class Shape : IShape
    {
        [Index(1)]
        public Shapes.ShapeType type;

        [Index(0)]
        public int Id;

        public double Area;
        public double Perimeter;
        public double CentroidX;
        public double CentroidY;
        public double CenterX;
        public double CenterY;
        public double SideLength;
        public double Orientation;


        public Shape(int Id, Shapes.ShapeType type,  double CenterX, double CenterY,
            double SideLength, double Orientation)
        {
            // The given information.
            this.Id = Id;
            this.type = type;
            this.CenterX = CenterX;
            this.CenterY = CenterY;
            this.SideLength = SideLength;
            this.Orientation = Orientation;

            // Will need to set these later once calculations are done.
            this.Area = 0;
            this.Perimeter = 0;
            this.CentroidX = 0;
            this.CentroidY = 0;
        }
    }
}
