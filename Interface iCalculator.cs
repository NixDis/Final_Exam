using System;

namespace Final_Exam_Program_Reyes
{
    internal interface iCalculator // this interface outlines the contract for any class that implements it and defines these two methods
    {
        double CalcCircumference(double radius);
        double CalcArea(double radius);
    }
    internal class Calculator : iCalculator // implements the iCalculator interface
    {
        public double CalcCircumference(double radius) // method for calculating the circumference
        {
            return 2 * Math.PI * radius;
        }

        public double CalcArea(double radius) // method for calculating the area
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}


