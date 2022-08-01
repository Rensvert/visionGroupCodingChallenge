using Microsoft.VisualStudio.TestTools.UnitTesting;
using visionGroupCodingChallenge;

namespace ProjectTest
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        [DataRow("1,Square,CenterX,363.122,CenterY,408.663,SideLength,76.802,Orientation,3.507", 5898.547204, 307.208)]
        [DataRow("2,Square,CenterX,103.017,CenterY,279.442,SideLength,90.603,Orientation,2.778", 8208.903609, 362.412)]
        [DataRow("3,Ellipse,CenterX,488.775,CenterY,136.852,R1,14.595,R2,23.366,Orientation,3.975", 1071.36719530946, 120.852558618044)]
        [DataRow("4,Ellipse,CenterX,234.756,CenterY,491.076,R1,1.518,R2,43.119,Orientation,6.254", 205.63182245055, 172.880520795273)]
        [DataRow("5,Circle,CenterX,338.591,CenterY,157.296,Radius,40.845", 5241.16308482082, 256.63670387175)]
        [DataRow("6,Circle,CenterX,424.026,CenterY,495.951,Radius,1.631", 8.35714225496608, 10.2478752360099)]
        [DataRow("7,Equilateral Triangle,CenterX,349.971,CenterY,263.142,SideLength,93.402,Orientation,4.32", 3777.57406099637, 280.206)]
        [DataRow("8,Equilateral Triangle,CenterX,273.408,CenterY,40.555,SideLength,18.712,Orientation,2.848", 151.614610179128, 56.136)]
        [DataRow("9,Polygon,X0,136.726,Y0,453.549,X1,494.272,Y1,321.349,X2,478.728,Y2,252.565,X3,381.482,Y3,15.197,X4,228.604,Y4,73.413,X5,190.502,Y5,171.571,X6,136.726,Y6,453.549", 92802.3130010731, 1264.17855076496)]
        [DataRow("10,Polygon,X0,97.457,Y0,439.096,X1,412.712,Y1,367.699,X2,429.11,Y2,339.875,X3,312.433,Y3,109.203,X4,97.457,Y4,439.096", 47840.3766543106, 1007.79325769393)]
        public void ShapeTest(string item, double area, double perimeter)
        {
            // SetUp
            var tolerance = 0.01;
            Converter convert = new Converter(item);

            // Act
            var shape = convert.ConvertToShape();
            shape.CalculateArea();
            shape.CalculatePerimeter();
            Assert.IsTrue((area - shape.Area) < tolerance);
            Assert.IsTrue((perimeter - shape.Perimeter) < tolerance);

        }


        // Used to have some stuff here but removed now.
        #region HelperMethods


        #endregion
    }
}
