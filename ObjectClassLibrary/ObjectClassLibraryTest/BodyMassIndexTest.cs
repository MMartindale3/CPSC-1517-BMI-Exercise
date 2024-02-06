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
        public void BodyMassIndex_Double_CalculatesBmiCorrectly()
        {
            // arrange
            BodyMassIndex patient = CreateTestBMI();
            double actual;

            // act
            actual = patient.Bmi;
            // assert
        }
    }
}