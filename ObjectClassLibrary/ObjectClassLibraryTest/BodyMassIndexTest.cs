using FluentAssertions;
using ObjectClassLibrary;

namespace ObjectClassLibraryTest
{
    public class BodyMassIndexTest
    {    
        // Constants for test BMI
        const string Name = "Jack Black";
        const double Weight = 180;
        const double Height = 65;

        public BodyMassIndex CreateTestBMI()
        {
            return new BodyMassIndex(Name, Weight, Height);
        }

        [Fact]
        public void BodyMassIndex_GreedyConstructor_ReturnsBodyMassIndex()
        {
            // arrange
            BodyMassIndex actual;

            // act
            actual = new BodyMassIndex(Name, Weight, Height);

            // assert
            actual.Should().NotBeNull();
            actual.Name.Should().Be(Name);
            actual.Weight.Should().Be(Weight);
            actual.Height.Should().Be(Height);
        }

        [Theory]
        [InlineData("", Weight, Height, "Name cannot be blank")]
        [InlineData(" ", Weight, Height, "Name cannot be blank")]
        [InlineData(Name, 0, Height, "Weight must be a positive non-zero value")]
        [InlineData(Name, -100, Height, "Weight must be a positive non-zero value")]
        [InlineData(Name, Weight, 0, "Height must be a positive non-zero value")]
        [InlineData(Name, Weight, -100, "Height must be a positive non-zero value")]

        public void BodyMassIndex_GreedyConstructor_ThrowsException(string name, double weight, double height, string errMsg) // why isn't this working? because there is no constructor on BMI.cs?
        {

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

        // BmiCategory() expected Jack Black BMI 30.0

        // Blank name Name: "", " "

        // Non-Positive Weight: 0, -100

        // Non-Positive Height: 0, -100

        // Underweight category person 1 and 2

        // Normal weight category person 1 and 2

        // Overweight category person 1 and 2

        // Obese category person 1 and 2

    }
}