using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using visionGroupCodingChallenge.Interfaces;
using visionGroupCodingChallenge.Shapes;

namespace visionGroupCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var ObjectList = new List<IShape>();
            var reader = new StreamReader(@"C:\Users\Rensv\Desktop\Shapes-49464.txt");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var item = ConvertToObject(line);
                var shape = ConvertToShape(item);
                ObjectList.Add(shape);
            }

            var records = new List<IShape>();
            foreach (var shape in ObjectList)
            {
                var modifiedShape = PerformOperations(shape);
                records.Add(modifiedShape);
            }

            //before the loop
            using (var writer = new StreamWriter(@"C:\Users\Rensv\Desktop\correctFileTest.txt"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                //register mapping class
                csv.Context.RegisterClassMap<ShapeMap>();

                //write header
                csv.WriteHeader<Shape>();

                // this is needed or else you get the header and the first entry on the same line.
                csv.NextRecord();
                foreach (var record in records)
                {
                    csv.WriteRecord(record);
                    csv.NextRecord();
                }
            }
        }

        // turns each line into a new Converter Object
        static Converter ConvertToObject(string line)
        {
            return new Converter(line);
        }

        // Makes an IShape
        static IShape ConvertToShape(Converter item)
        {
            return item.ConvertToShape();
        }


        // Perform the operations on the IShape, so that we have the data we need to write.
        static IShape PerformOperations(IShape shape)
        {
            shape.CalculateArea(shape.Radius);
            shape.CalculatePerimeter(shape);
            shape.CalculateCentroidX(shape);
            shape.CalculateCentroidY(shape);
            return shape;
        }
    }
}
