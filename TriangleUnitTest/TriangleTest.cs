using System;
using Xunit;
using TestDrivenDevelopment;

namespace TriangleUnitTest
{
    public class CalculatorTest
    {
        [TestMethod]
        public void Test1()
        {
            TriangleCalculator.calculateSum()
        }

        private class TestMethodAttribute : Attribute
        {

        }
    }
}
