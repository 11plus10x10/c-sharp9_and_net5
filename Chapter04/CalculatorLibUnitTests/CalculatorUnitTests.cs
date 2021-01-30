/*
 * A well written test will have three parts:
 *    1. Arrange: this part will declare and instantiate variables for input and output.
 *    2. Act: this part will execute the unit that you are testing.
 *        In this case that means calling the method I want to test.
 *    3. Assert: This part will make one or more assertions about the output.
 *         An assertion is a belief that if not true indicates a failed test. For example, when
 *         adding 2 and 2 we would expect the result would be 4.
 */

using Packt;
using System;
using Xunit;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            // Arrange.
            var a = 2.0;
            var b = 2.0;
            var expected = 4.0;
            var calc = new Calculator();
            
            // Act.
            var actual = calc.Add(a, b);
            
            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding3And2()
        {
            // Arrange.
            var a = 3.0;
            var b = 2.0;
            var expected = a + b;
            var calc = new Calculator();
            
            // Act.
            var actual = calc.Add(a, b);
            
            // Assertion.
            Assert.Equal(expected, actual);
        }
    }
}
