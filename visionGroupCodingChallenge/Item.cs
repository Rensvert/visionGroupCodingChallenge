using System;
using System.Collections.Generic;
using System.Text;

namespace visionGroupCodingChallenge
{
    public class Item
    {
        public List<Attribute> entries { get; set; }
        public string Name;
        public int Id;
        public int CenterX;
        public int CenterY;
        public int Orientation;


        public List<int> XCoordinates;
        public List<int> YCoordinates;

    }
}
