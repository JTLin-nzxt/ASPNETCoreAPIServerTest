using NUnit.Framework;
using System;
using CalculatorApp; // Assuming Calculator class is in this namespace

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int num1 = 5;
            int num2 = 3;
            int expected = 8;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_PositiveAndNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int num1 = 10;
            int num2 = -4;
            int expected = 6;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_ZeroToNumber_ReturnsNumber()
        {
            // Arrange
            int num1 = 7;
            int num2 = 0;
            int expected = 7;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int num1 = 10;
            int num2 = 4;
            int expected = 6;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Subtract_NegativeFromPositive_ReturnsCorrectDifference()
        {
            // Arrange
            int num1 = 5;
            int num2 = -3;
            int expected = 8; // 5 - (-3) = 8

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Subtract_NumberFromZero_ReturnsNegativeNumber()
        {
            // Arrange
            int num1 = 0;
            int num2 = 5;
            int expected = -5;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int num1 = 6;
            int num2 = 7;
            int expected = 42;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Multiply_PositiveAndNegative_ReturnsCorrectProduct()
        {
            // Arrange
            int num1 = -5;
            int num2 = 3;
            int expected = -15;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Multiply_ByZero_ReturnsZero()
        {
            // Arrange
            int num1 = 100;
            int num2 = 0;
            int expected = 0;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            int num1 = 10;
            int num2 = 2;
            int expected = 5;

            // Act
            int result = _calculator.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_NegativeByPositive_ReturnsCorrectQuotient()
        {
            // Arrange
            int num1 = -12;
            int num2 = 3;
            int expected = -4;

            // Act
            int result = _calculator.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            // Arrange
            int num1 = 0;
            int num2 = 5;
            int expected = 0;

            // Act
            int result = _calculator.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int num1 = 10;
            int num2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(num1, num2));
        }
    }
}
