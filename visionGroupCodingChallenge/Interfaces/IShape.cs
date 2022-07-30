namespace visionGroupCodingChallenge.Interfaces
{
    // Interface for the different shapes, and the methods needed to do the different calculations.
    public interface IShape
    {
        int Id { get; set; }

        double Area { get; set; }
        double Perimeter { get; set; }
        double CentroidX { get; set; }
        double CentroidY { get; set; }

        void CalculateArea(IShape shape);

        void CalculatePerimeter(IShape shape);

        void CalculateCentroidX(IShape shape);

        void CalculateCentroidY(IShape shape);
    }
}
