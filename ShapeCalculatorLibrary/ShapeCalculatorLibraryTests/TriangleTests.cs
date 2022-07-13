using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculatorLibrary;

namespace ShapeCalculatorLibraryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Square_a10_b7_c6_returned_20_662()
        {
            //arrange
            double a = 10;
            double b = 7;
            double c = 6;
            double expected = 20.662;
            //act
            Triangle triangle = new Triangle(a,b,c);
            double actual = triangle.CalcSquare();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}