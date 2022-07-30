using CsvHelper.Configuration;
using visionGroupCodingChallenge.Interfaces;

namespace visionGroupCodingChallenge.Shapes
{
    public class ShapeMap : ClassMap<IShape>
    {
        public ShapeMap()
        {
            Map(m => m.Id).Index(0).Name("Id");
            Map(m => m.Area).Index(1).Name("Area");
            Map(m => m.Perimeter).Index(2).Name("Perimeter");
            Map(m => m.CentroidX).Index(3).Name("CentroidX");
            Map(m => m.CentroidY).Index(4).Name("CentroidY");

        }
    }
}
