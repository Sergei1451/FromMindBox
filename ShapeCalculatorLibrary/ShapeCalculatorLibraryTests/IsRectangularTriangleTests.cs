using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculatorLibrary;

namespace ShapeCalculatorLibraryTests
{
    [TestClass]
    public class IsRectangularTriangleTests
    {
        [TestMethod]
        public void IsRectangular_a10_b8_c6_returned_true_or_false()
        {
            //arrange
            double a = 10;
            double b = 8;
            double c = 6;
            bool expected = true;
            //act
            Triangle triangle = new Triangle(a,b,c);
            bool actual = triangle.IsRectangular();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}