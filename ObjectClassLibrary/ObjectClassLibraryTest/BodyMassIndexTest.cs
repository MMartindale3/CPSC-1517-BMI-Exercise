using FluentAssertions;
using ObjectClassLibrary;
using System.Runtime.CompilerServices;

namespace ObjectClassLibraryTest
{
    public class BodyMassIndexTest
    {    
        // Constants for test BMI
        const string Name = "Jack Black";
        const double Weight = 180;
        const double Height = 65;

        /// <summary>
        /// Creates a default BodyMassIndex for testing
        /// </summary>
        /// <returns>a new BodyMassIndex</returns>
        public BodyMassIndex CreateTestBMI()
        {
            return new BodyMassIndex(Name, Weight, Height);
        }

        // Good BodyMassIndex constructor
        [Theory]
        [InlineData(Name, Weight, Height)]
        public void BodyMassIndex_GreedyConstructor_ReturnsBodyMassIndex(string name, double weight, double height)
        {
            // arrange
            BodyMassIndex actual;

            // act
            actual = new BodyMassIndex(name, weight, height);

            // assert
            actual.Should().NotBeNull();
        }

        // Failing BodyMassIndex constructor
        [Theory]
        [InlineData("", Weight, Height, "Name cannot be blank")]
        [InlineData(" ", Weight, Height, "Name cannot be blank")]
        [InlineData(Name, 0, Height, "Weight must be a positive non-zero number")]
        [InlineData(Name, -100, Height, "Weight must be a positive non-zero number")]
        [InlineData(Name, Weight, 0, "Height must be a positive non-zero number")]
        [InlineData(Name, Weight, -100, "Height must be a positive non-zero number")]
        public void BodyMassIndex_GreedyConstructor_ThrowsException(string name, double weight, double height, string errMsg)
        {
            // arrange
            Action act = () => new BodyMassIndex(name, weight, height);

            // act / assert
            act.Should().Throw<ArgumentException>().WithMessage(errMsg);

            
        }

        //[Fact]
        //public void BodyMassIndex_Bmi_CalculatesBmiCorrectly()
        //{
        //    // arrange
        //    BodyMassIndex patient = CreateTestBMI();
        //    double actual;

        //    // act
        //    actual = patient.Bmi; // how am I supposed to do this for a method vs a property??

        //    // assert
        //}

        // BmiCategory() expected Jack Black BMICategory Obese

        // Underweight category person 1 and 2

        // Normal weight category person 1 and 2

        // Overweight category person 1 and 2

        // Obese category person 1 and 2

    }
}