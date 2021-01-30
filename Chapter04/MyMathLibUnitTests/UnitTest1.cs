using System;
using System.Collections.Generic;
using Xunit;
using MyMathLib;

namespace MyMathLibUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PrimeFactOf4()
        {
            // Arrange.
            var expected = new List<int> {2, 2};
            var primeNum = new PrimeNumber();
            
            // Act.
            List<int> actual = primeNum.GetPrimeFactors(4);

            // Assert.
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void PrimeFactorOf7()
        {
            // Arrange.
            var expected = new List<int> { 7 };
            var primeNum = new PrimeNumber();
            
            // Act.
            List<int> actual = primeNum.GetPrimeFactors(7);
            
            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorOf30()
        {
            // Arrange.
            var expected = new List<int> { 2, 3, 5 };
            var primeNum = new PrimeNumber();
            
            // Act.
            List<int> actual = primeNum.GetPrimeFactors(30);
            
            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorOf315()
        {
            // Arrange.
            var expected = new List<int> { 3, 3, 5, 7 };
            var primeNum = new PrimeNumber();
            
            // Act.
            List<int> actual = primeNum.GetPrimeFactors(315);
            
            // Assert.
            Assert.Equal(expected, actual);
        }
    }
}
