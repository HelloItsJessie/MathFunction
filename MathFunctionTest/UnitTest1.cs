using System;
using Xunit;
using MathFunction;

namespace MathFunctionTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, -3, 2)]
        [InlineData(5, -3, 4)]
        [InlineData(8, -3, 6)]
        public void RunCalculating_DeltaLessThan0_ReturnsNoResults(double a, double b, double c)
        {
            var mathFunction = new MathFunc(a, b, c);

            Assert.Equal("No results", mathFunction.RunCalculating());
        }


        [Theory]
        [InlineData(1,2,1)]
        [InlineData(4,4,1)]
        [InlineData(1,6,9)]
        public void RunCalculating_GetDelta_IsEqualZero(double a, double b, double c)
        {
            var mathFunction = new MathFunc(a, b, c);
            Assert.Equal(0, mathFunction.GetDelta());
        }

        [Theory]
        [InlineData(1, 9, 1)]
        [InlineData(4, 10, 1)]
        [InlineData(1, 7, 9)]
        public void RunCalculating_GetDelta_IsGreaterThanZero(double a, double b, double c)
        {
            var mathFunction = new MathFunc(a, b, c);
            Assert.True(mathFunction.GetDelta() > 0, "Not greater than 0");
        }
    }
}
