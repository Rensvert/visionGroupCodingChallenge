using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using visionGroupCodingChallenge.Interfaces;
using visionGroupCodingChallenge.Shapes;

namespace visionGroupCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var ObjectList = new List<Shape>();
            var reader = new StreamReader(@"C:\Users\Rensv\Desktop\Shapes-49464.txt");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // var check = JsonConvert.DeserializeObject<Item>(json);
                var item = ConvertToObject(line);
                var shape = ConvertToShape(item);
                ObjectList.Add(shape);
                //Console.WriteLine(reader.ReadLine());
            }

            var listOfShapeModified = new List<Shape>();
            foreach(var shape in ObjectList)
            {
                var modifiedShape = PerformOperations(shape);
                listOfShapeModified.Add(modifiedShape);
            }

            var records = new List<Shape>();
            var shapetest = new Shape(1,ShapeType.Square, 51.1, 51.4, 11.75, 212.222);
            records.Add(shapetest);
            var head = "Test, test2, testttt";

            //before your loop
            using (var writer = new StreamWriter(@"C:\Users\Rensv\Desktop\correctFileTest.txt"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // csv.WriteHeader<head>();
                csv.Context.RegisterClassMap<ShapeMap>();
                csv.NextRecord();
                foreach (var record in records)
                {
                    csv.WriteRecord(record);
                    csv.NextRecord();
                }
            }
            var x = 13;

        }

        static Converter ConvertToObject(string line)
        {
            return new Converter(line);
        }

        static Shape ConvertToShape(Converter item)
        {
            return item.ConvertToShape();
        }


        // TODO Perform the operations and create new shape 
        // Create a new Shape so that we still have an unmodified shape, this ensures no side effects on unintentially modifying existing items.
        static Shape PerformOperations(Shape shape)
        {
            // just for testing purposes.
            return new Shape(51, ShapeType.Unknown, 100.0, 100.0, 110.22, 1.11);
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
      
                //var Shape = new Shape(type, Convert.ToDouble(values[2]),
                //    Convert.ToDouble(values[4]), Convert.ToDouble(values[6]),
                //    Convert.ToDouble(values[8]));
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
