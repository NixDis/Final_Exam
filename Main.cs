using System;

namespace Final_Exam_Program_Reyes
{
    internal class UserInterface
    {
        private static void Main(string[] args)
        {
            bool runAgain;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Geometry Calculator ===");
                Console.WriteLine("1. Circle Circumference Calculator");
                Console.WriteLine("2. Circle Area Calculator");
                Console.Write("Enter your choice (1 or 2): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        RunCircleCircumferenceCalculator();
                        break;
                    case 2:
                        Console.Clear();
                        RunCircleAreaCalculator();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
                Console.Write("Do you want to run the program again? (Y/N): ");
                char repeatChoice = Console.ReadLine().ToUpper()[0];
                runAgain = (repeatChoice == 'Y' || repeatChoice == 'y');

            } while (runAgain);
        }

        private static void RunCircleCircumferenceCalculator()  // method creates an instance of Calculator and WrapperOfCalculator
        {
            Console.WriteLine("=== Circle Circumference Calculator ===");

            iCalculator obj = new Calculator(); //instanctiating Calculator to obj (new object)
            WrapperOfCalculator wrap = new WrapperOfCalculator(obj); //creating a wrapper object
            wrap.UserInPut();

            double circumference = wrap.CalcCircumference(); // calling the method CalculateCircumference() in Calculator Class
            Console.WriteLine("The circumference of the circle is: {0:F4}", circumference);
        }

        private static void RunCircleAreaCalculator() // method creates an instance of Calculator and WrapperOfCalculator
        {
            Console.WriteLine("=== Circle Area Calculator ===");

            iCalculator obj = new Calculator(); //instanctiating Calculator to obj (new object)
            WrapperOfCalculator wrap = new WrapperOfCalculator(obj); //creating a wrapper object
            wrap.UserInPut();

            double area = wrap.CalcArea(); // calling the method CalculateArea() in Calculator Class
            Console.WriteLine("The area of the circle is: {0:F4}", area);
        }
    }
}

