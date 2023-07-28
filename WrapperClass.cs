using System;

namespace Final_Exam_Program_Reyes
{
    internal class WrapperOfCalculator // acts as a wrapper for the Calculator class
    {                                 
        private double radius; // private field to store the radius value entered by the user
        private iCalculator _calculator; // private field to store an instance of the iCalculator interface

        internal double Radius // property to access the radius field
        {
            get { return radius; }
            set { radius = value; }
        }

        internal WrapperOfCalculator(iCalculator calculator) // constructor that takes an instance of the iCalculator class as an argument
        {                                                   // and stores it in the _calculator field
            _calculator = calculator;
        }

        internal double CalcCircumference() // method that calls the CalculateCircumference method of the Calculator class
        {                                        // with the stored radius and returns the calculated circumference
            return _calculator.CalcCircumference(radius);
        }

        internal double CalcArea() // method that calls the CalculateArea method of the Calculator class
        {                               // with the stored radius and returns the calculated area
            return _calculator.CalcArea(radius);
        }

        internal void UserInPut() // method that prompts the user to enter the radius and validates the input to ensure a non-negative
        {                         // numeric value is provided. If the user enters a valid value, it stores the radius in the radius field
            bool validRadius = false;
            do
            {
                Console.Write("Enter the radius of the circle: ");
                string input = Console.ReadLine();

                try
                {
                    radius = Convert.ToDouble(input);

                    if (radius > 0)
                    {
                        validRadius = true;
                    }
                    else if (radius == 0) 
                    {
                        throw new ArgumentException("Please enter a non-zero value.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a non-negative value.");
                    }
                }
                catch (FormatException) // to catch and handle exceptions when input is not a appropriate format such as string
                {
                    Console.WriteLine("Please enter a valid numeric value.");
                }
                catch (ArgumentException e) 
                {
                    Console.WriteLine("" + e.Message);
                }
                finally
                {
                     Console.WriteLine("Thank you for using my program.\n");
                }
            } while (!validRadius);
        }
    }
}

