using System;
using System.Collections.Generic;
using System.Text;

namespace visionGroupCodingChallenge
{
    public class Converter
    {
        string convertItem;
        public Converter(string item)
        {
            convertItem = item;
        }

        public Shape ConvertToShape()
        {
            var itemList = convertItem.Split(',');

            //   var Shape = new Shape(itemList[0]);

            // return Shape;

            return null;
        }
    }
}
