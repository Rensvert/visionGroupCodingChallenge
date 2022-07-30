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

        double CenterX { get; set; }
        double CenterY { get; set; }

        void CalculateArea(double number);

        void CalculatePerimeter(IShape shape);

        void CalculateCentroidX(IShape shape);

        void CalculateCentroidY(IShape shape);
    }
}
