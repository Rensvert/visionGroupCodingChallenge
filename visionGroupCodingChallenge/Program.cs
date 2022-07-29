using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using visionGroupCodingChallenge.Interfaces;
using visionGroupCodingChallenge.Shapes;

namespace visionGroupCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var ObjectList = new List<Item>();
            var reader = new StreamReader(@"C:\Users\Rensv\Desktop\Shapes-49464.json");
            while (!reader.EndOfStream)
            {
                var json = reader.ReadToEnd();
                var check = JsonConvert.DeserializeObject<Item>(json);
                var x = 13;
             //   ObjectList.Add(line);
                //Console.WriteLine(reader.ReadLine());
            }
        //    var newList = ConvertInputsIntoObjects(ObjectList);

        }

        static List<Shape> ConvertInputsIntoObjects(List<string> stringList)
        {
            var returnList = new List<Shape>();

            foreach(var line in stringList)
            {
                var values = line.Split(',');
                var type = ConvertType(values[1]);

                if (type == ShapeType.Polygon)
                {
                    var xList = GetXListPoly(values);
                    var yList = GetYListPoly(values);
                }
      
                var Shape = new Shape(type, Convert.ToDouble(values[2]),
                    Convert.ToDouble(values[4]), Convert.ToDouble(values[6]),
                    Convert.ToDouble(values[8]));
            }


            return returnList;
        }

        private static object GetYListPoly(string[] values)
        {
            throw new NotImplementedException();
        }

        private static object GetXListPoly(string[] values)
        {
            throw new NotImplementedException();
        }

        static ShapeType ConvertType(string type)
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
