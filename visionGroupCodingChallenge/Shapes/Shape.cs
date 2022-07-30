namespace visionGroupCodingChallenge
{
    // Base class of the different Shapes.
    public class Shape
    {
        public Shapes.ShapeType type;

        public int Id { get; set; }

        public double Area { get; set; }
        public double Perimeter { get; set; }
        public double Radius { get; set; }
        public double CentroidX { get; set; }
        public double CentroidY { get; set; }
     
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double SideLength;
        public double Orientation;
        public double R1;
        public double R2;

        public Shape(int Id)
        {
            this.Id = Id;
        }

    }
}
