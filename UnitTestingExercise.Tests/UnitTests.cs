using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]//Add test data <-------
        [InlineData(0, 0, 0, 0)]
        [InlineData(1, 4, 8, 13)]
        [InlineData(-2, 1, 2, 1)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            
            //Arrange
            // create a Calculator object
            var x = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = x.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]//Add test data <-------
        [InlineData(20, 18, 2)]
        [InlineData(-5, 5, -10)]
        [InlineData(0, 5, -5)]
        [InlineData(4, 0, 4)]
        public void SubtractTest(int num1, int num2, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var x = new Calculator();
            //Act
            var actual = x.Subtract(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]   //Add test data <-------
        [InlineData(-5, 3, -15)]
        [InlineData(0, 3, 0)]
        [InlineData(0, -2, 0)]
        [InlineData(20, 2, 40)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var x = new Calculator();
            //Act
            var actual = x.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,4,2)]//Add test data <-------
        [InlineData(16, 4, 4)]
        [InlineData(0, 4, 0)]
        [InlineData(-10, 2, -5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var x = new Calculator();
            //Act
            var actual = x.Divide(num1, num2);

            //Assert
            Assert.Equal(expected,actual);
       
        }

    }
}
