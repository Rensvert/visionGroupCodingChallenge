using Microsoft.Azure.Devices.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using visionGroupCodingChallenge.Shapes;

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
            var returnShape = new Shape(Convert.ToInt32(itemList[0]));
            var type = ConvertType(itemList[1]);

            if (type == ShapeType.Polygon)
            {

            }
            else if (type == ShapeType.Circle)
            {
                returnShape.type = type;
                returnShape.CenterX = Convert.ToDouble(itemList.ElementAtOrDefault(3) ?? null);
                returnShape.CenterY = Convert.ToDouble(itemList.ElementAtOrDefault(5) ?? null);
                returnShape.Radius = Convert.ToDouble(itemList.ElementAtOrDefault(7) ?? null);

            }
            else if (type == ShapeType.Square)
            {
                returnShape.type = type;
                returnShape.CenterX = Convert.ToDouble(itemList.ElementAtOrDefault(3) ?? null);
                returnShape.CenterY = Convert.ToDouble(itemList.ElementAtOrDefault(5) ?? null);
                returnShape.SideLength = Convert.ToDouble(itemList.ElementAtOrDefault(7) ?? null);
                returnShape.Orientation = Convert.ToDouble(itemList.ElementAtOrDefault(9) ?? null);
                returnShape.Area = 51.123123;

            }


            return returnShape;
        }

        ShapeType ConvertType(string type)
        {
            switch (type)
            {
                case "Square":
                    {
                        return ShapeType.Square;
                    }
                case "Ellipse":
                    {
                        return ShapeType.Ellipse;
                    }
                case "Circle":
                    {
                        return ShapeType.Circle;
                    }
                case "Equilateral Triangle":
                    {
                        return ShapeType.Triangle;
                    }
                case "Polygon":
                    {
                        return ShapeType.Polygon;
                    }
                default:
                    return ShapeType.Unknown;
            }

        }
    }
}
