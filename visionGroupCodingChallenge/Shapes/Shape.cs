namespace visionGroupCodingChallenge
{
    // Base class of the different Shapes.
    public class Shape
    {
        public Shapes.ShapeType type;

        public int Id { get; set; }

        public double Area { get; set; }
        public double Perimeter { get; set; }
        public double CentroidX { get; set; }
        public double CentroidY { get; set; }
     

        public double Orientation;


        public Shape(int Id)
        {
            this.Id = Id;
        }

    }
}
