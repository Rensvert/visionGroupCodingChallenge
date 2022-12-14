using System;
using System.Linq;
using visionGroupCodingChallenge.Interfaces;
using visionGroupCodingChallenge.Shapes;
using visionGroupCodingChallenge.Shapes.IndividualShapes;

namespace visionGroupCodingChallenge
{
    public class Converter
    {
        string convertItem;

        public Converter(string item)
        {
            convertItem = item;
        }

        // takes the csv Array and populate the data into the correct Shape Object.
        public IShape ConvertToShape()
        {

            var itemList = convertItem.Split(',');
            var type = ConvertType(itemList[1]);

            if (type == ShapeType.Polygon)
            {
                var returnShape = new Polygons(Convert.ToInt32(itemList[0]));
                returnShape.type = type;

                PopulateVertList(itemList, returnShape);

                return returnShape;

            }
            else if (type == ShapeType.Circle)
            {
                var returnShape = new Circle(Convert.ToInt32(itemList[0]));

                returnShape.type = type;
                returnShape.CenterX = Convert.ToDouble(itemList.ElementAtOrDefault(3) ?? null);
                returnShape.CenterY = Convert.ToDouble(itemList.ElementAtOrDefault(5) ?? null);
                returnShape.Radius = Convert.ToDouble(itemList.ElementAtOrDefault(7) ?? null);
                return returnShape;
            }

            else if (type == ShapeType.Square)
            {
                var returnShape = new Square(Convert.ToInt32(itemList[0]));
                returnShape.type = type;
                returnShape.CenterX = Convert.ToDouble(itemList.ElementAtOrDefault(3) ?? null);
                returnShape.CenterY = Convert.ToDouble(itemList.ElementAtOrDefault(5) ?? null);
                returnShape.SideLength = Convert.ToDouble(itemList.ElementAtOrDefault(7) ?? null);
                returnShape.Orientation = Convert.ToDouble(itemList.ElementAtOrDefault(9) ?? null);
                return returnShape;

            }

            else if (type == ShapeType.Triangle)
            {
                var returnShape = new Triangle(Convert.ToInt32(itemList[0]));
                returnShape.type = type;
                returnShape.CenterX = Convert.ToDouble(itemList.ElementAtOrDefault(3) ?? null);
                returnShape.CenterY = Convert.ToDouble(itemList.ElementAtOrDefault(5) ?? null);
                returnShape.SideLength = Convert.ToDouble(itemList.ElementAtOrDefault(7) ?? null);
                returnShape.Orientation = Convert.ToDouble(itemList.ElementAtOrDefault(9) ?? null);
                return returnShape;
            }

            else if (type == ShapeType.Ellipse)
            {
                var returnShape = new Ellipses(Convert.ToInt32(itemList[0]));

                returnShape.type = type;
                returnShape.CenterX = Convert.ToDouble(itemList.ElementAtOrDefault(3) ?? null);
                returnShape.CenterY = Convert.ToDouble(itemList.ElementAtOrDefault(5) ?? null);
                returnShape.R1 = Convert.ToDouble(itemList.ElementAtOrDefault(7) ?? null);
                returnShape.R2 = Convert.ToDouble(itemList.ElementAtOrDefault(9) ?? null);
                returnShape.Orientation = Convert.ToDouble(itemList.ElementAtOrDefault(11) ?? null);
                return returnShape;
            }
            return null;   
        }

        private void PopulateVertList(string[] itemList, Polygons polygon)
        {
            bool isX = false;
            bool isY = false;

            foreach(var item in itemList)
            {
                if (isX)
                {
                    polygon.XList.Add(Convert.ToDouble(item));
                    isX = false;
                    continue;
                }
                if (isY)
                {
                    polygon.YList.Add(Convert.ToDouble(item));
                    isY = false;
                    continue;
                }

                if (item.Contains("X"))
                {
                    isX = true;
                    continue;
                }
                if (item.Contains("Y"))
                {
                    isY = true;
                    continue;
                }
            }

        }



        // Get the enum for the shape we have.
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
