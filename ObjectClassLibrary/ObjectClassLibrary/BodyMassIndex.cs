using System.Numerics;

namespace ObjectClassLibrary
{
    public class BodyMassIndex
    {
        /* TODO:
         *  Fix the code in Jack’s BodyMassIndex class until all test cases pass. For each error you fix you
         *  must document the error that you fixed by commenting out the incorrect code, add a description of
         *  the problem, and the code to fix the problem.
         */
        private string _name;  // created _name to allow us to set name      
        private double _weight;
        private double _height;
        public string Name // expanded Name property to allow us to set and validate _name
        {

            get
            {
                return _name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Name cannot be blank"); // updated arguement exception format and message
                }
                _name = value; // corrected
            }

        }

        public double Weight
        {
            get
            {
                //return _height; Weight must return _weight, not _height
                return _weight;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight must be a positive non-zero number"); // updated arguement exception format and message
                }
                // Height = value; incorrect use of height, also does not use a field
                _weight = value; // corrected
            }
        }
        public double Height
        {
            get
            {
                return Height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be a positive non-zero number"); // updated arguement exception format and message
                }
                _height = value;
            }
        }
        public BodyMassIndex(string name, double weight, double height)
        {
            // moved name validation to Name properties
            // these are just weird and inconsistent
            //this.Weight = weight; 
            //height = this.Height;
            Name = name.Trim(); // added name with trimming
            Weight = weight; // corrected weight
            Height = height; // corrected height

        }

        /// <summary>
        /// Calculate the body mass index (BMI) using the weight and height of the person.
        ///
        /// The BMI of a person is calculated using the formula: BMI = 700 * weight / (height* height)
        /// where weight is in pounds and height is in inches.
        /// </summary>
        /// <returns>the body mass index (BMI) value of the person</returns>

        public double Bmi()
        {
            double bmiValue = 703 * Weight / Math.Pow(2, Height);
            bmiValue = Math.Round(bmiValue, 1);
            return bmiValue;
        }

        /// <summary>
        /// Determines the BMI Category of the person using their BMI value.
        /// </summary>
        /// <returns>one of following: underweight, normal, overweight, obese.</returns>
        public string BmiCategory()
        {
            string category = "Unknown";
            double bmiValue = Bmi();
            if (bmiValue < 18.5)
            {
                category = "underweight";
            }
            if (bmiValue < 24.9)
            {
                category = "normal";
            }
            if (bmiValue < 29.9)
            {
                category = "overweight";
            }
            if (bmiValue >= 30)
            {
                category = "obese";
            }
            return category;
        }
    }
}
