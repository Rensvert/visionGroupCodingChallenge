namespace visionGroupCodingChallenge.Interfaces
{
    public interface IShape
    {
        int Id { get; set; }

        double Area { get; set; }
        double Perimeter { get; set; }
        double CentroidX { get; set; }
        double CentroidY { get; set; }
        double Radius { get; set; }

        void CalculateArea(double number);

        void CalculatePerimeter(IShape shape);

        void CalculateCentroidX(Shape shape);

        void CalculatCentroidY(Shape shape);
    }
}
