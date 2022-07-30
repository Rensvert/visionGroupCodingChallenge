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
                var item = ConvertToObject(line);
                var shape = ConvertToShape(item);
                ObjectList.Add(shape);
            }


            var records = new List<Shape>();
            foreach (var shape in ObjectList)
            {
                var modifiedShape = PerformOperations(shape);
                records.Add(modifiedShape);
            }

            var head = "Test, test2, testttt";

            //before your loop
            using (var writer = new StreamWriter(@"C:\Users\Rensv\Desktop\correctFileTest.txt"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ShapeMap>();

                csv.WriteHeader<Shape>();
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
            return shape;
        }
    }
}
