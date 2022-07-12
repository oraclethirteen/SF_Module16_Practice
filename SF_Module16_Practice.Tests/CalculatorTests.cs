using System;
using System.Text;
using NUnit.Framework;

namespace SF_Module16_Practice.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Addition(5, 10) == 15);
        }
        
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Subtraction(15, 5) == 10);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Multiplication(10, 5) == 50);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Division(15, 5) == 3);
        }

        [Test]
        public void DivisionMustThrowDivideByZeroException()
        {
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(5, 0));
        }
    }
}
