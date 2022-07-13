using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculatorLibrary;

namespace ShapeCalculatorLibraryTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Square_Radius_10_returned_314_159()
        {
            //arrange
            double radius = 10;
            double expected = 314.159;
            //act
            Circle circle = new Circle(radius);
            double actual = circle.CalcSquare();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}