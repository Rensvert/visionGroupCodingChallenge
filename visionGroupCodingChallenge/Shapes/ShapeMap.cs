using CsvHelper.Configuration;


namespace visionGroupCodingChallenge.Shapes
{
    public class ShapeMap : ClassMap<Shape>
    {
        public ShapeMap()
        {
            Map(m => m.Id).Index(0).Name("id");
            Map(m => m.type).Index(1).Name("type");
        }
    }
}
