using System;
using System.Linq;
using System.Collections.Generic;
using PrimeFactoringLib;
using Xunit;

namespace PrimeFactoringTests
{
    public class PrimeFactoringUnitTests
    {
        private static int Multiply(int a, int b) { return a * b; }

        [Fact]
        public void Test1()
        {
            // Arrange
            var originalNumber = 50;
            var expetctedPrimeFactors = new List<int>(){2, 5, 5};
            var primeFacLib = new PrimeFactoring();

            // Act
            var actualPrimeFactors = primeFacLib.GetPrimeFactors(originalNumber);
            var multipliedPrimes = actualPrimeFactors.Aggregate(func: Multiply);
            
            // Assert
            Assert.Equal(expetctedPrimeFactors, actualPrimeFactors);
            Assert.Equal(multipliedPrimes, originalNumber);
        }
         [Fact]
        public void Test2()
        {
            // Arrange
            var originalNumber = 40;
            var expetctedPrimeFactors = new List<int>(){2, 2, 2, 5};
            var primeFacLib = new PrimeFactoring();

            // Act
            var actualPrimeFactors = primeFacLib.GetPrimeFactors(originalNumber);
            var multipliedPrimes = actualPrimeFactors.Aggregate(func: Multiply);
            
            // Assert
            Assert.Equal(expetctedPrimeFactors, actualPrimeFactors);
            Assert.Equal(multipliedPrimes, originalNumber);
        }

        [Fact]
        public void Test3()
        {
                       // Arrange
            var originalNumber = 4;
            var expetctedPrimeFactors = new List<int>(){2, 2};
            var primeFacLib = new PrimeFactoring();

            // Act
            var actualPrimeFactors = primeFacLib.GetPrimeFactors(originalNumber);
            var multipliedPrimes = actualPrimeFactors.Aggregate(func: Multiply);
            
            // Assert
            Assert.Equal(expetctedPrimeFactors, actualPrimeFactors);
            Assert.Equal(multipliedPrimes, originalNumber);
        }
        
        [Fact]
        public void Test4()
        {
            // Arrange
            var originalNumber = 85;
            var expetctedPrimeFactors = new List<int>(){5, 17};
            var primeFacLib = new PrimeFactoring();

            // Act
            var actualPrimeFactors = primeFacLib.GetPrimeFactors(originalNumber);
            var multipliedPrimes = actualPrimeFactors.Aggregate(func: Multiply);
            
            // Assert
            Assert.Equal(expetctedPrimeFactors, actualPrimeFactors);
            Assert.Equal(multipliedPrimes, originalNumber);
        }
        
        [Fact]
        public void Test5()
        {
            // Arrange
            var originalNumber = 103; // 103 is a prime number
            
            var expetctedPrimeFactors = new List<int>(){103};
            var primeFacLib = new PrimeFactoring();

            // Act
            var actualPrimeFactors = primeFacLib.GetPrimeFactors(originalNumber);
            var multipliedPrimes = actualPrimeFactors.Aggregate(func: Multiply);
            
            // Assert
            Assert.Equal(expetctedPrimeFactors, actualPrimeFactors);
            Assert.Equal(multipliedPrimes, originalNumber);
        }

        [Fact]
        public void Test6()
        {
            // Arrange
            var originalNumber = 87;
            var expetctedPrimeFactors = new List<int>(){3, 29};
            var primeFacLib = new PrimeFactoring();

            // Act
            var actualPrimeFactors = primeFacLib.GetPrimeFactors(originalNumber);
            var multipliedPrimes = actualPrimeFactors.Aggregate(func: Multiply);
            
            // Assert
            Assert.Equal(expetctedPrimeFactors, actualPrimeFactors);
            Assert.Equal(multipliedPrimes, originalNumber);
        }

        [Fact]
        public void Test7()
        {
            // Arrange
            var originalNumber = 111;
            var expetctedPrimeFactors = new List<int>(){3, 37};
            var primeFacLib = new PrimeFactoring();

            // Act
            var actualPrimeFactors = primeFacLib.GetPrimeFactors(originalNumber);
            var multipliedPrimes = actualPrimeFactors.Aggregate(func: Multiply);
            
            // Assert
            Assert.Equal(expetctedPrimeFactors, actualPrimeFactors);
            Assert.Equal(multipliedPrimes, originalNumber);
        }
    }
}
