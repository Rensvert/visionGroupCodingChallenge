using System;
using System.IO;

namespace visionGroupCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            var reader = new StreamReader(@"C:\Users\Rensv\Desktop\Shapes-49464.txt");
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
