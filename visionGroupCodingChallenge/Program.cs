using System;
using System.Collections.Generic;
using System.IO;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var ObjectList = new List<string>();
            var reader = new StreamReader(@"C:\Users\Rensv\Desktop\Shapes-49464.txt");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                ObjectList.Add(line);
                //Console.WriteLine(reader.ReadLine());
            }
            var newList = ConvertInputsIntoObjects(ObjectList);

        }

        static List<Shape> ConvertInputsIntoObjects(List<string> stringList)
        {
            var returnList = new List<Shape>();


            return returnList;
        }
    }
}
