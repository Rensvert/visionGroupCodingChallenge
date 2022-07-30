namespace visionGroupCodingChallenge.Interfaces
{
    public interface IShape
    {
        //int Id { get; set; }

        //double Area { get; set; }
        //double Perimeter { get; set; }
        //double CentroidX { get; set; }
        //double CentroidY { get; set; }

        void CalculateArea(Shape shape);

        void CalculatePerimeter(Shape shape);

        void CalculateCentroidX(Shape shape);

        void CalculatCentroidY(Shape shape);
    }
}
