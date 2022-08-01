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

        void CalculateArea();

        void CalculatePerimeter();

        void CalculateCentroidX(IShape shape);

        void CalculateCentroidY(IShape shape);
    }
}
