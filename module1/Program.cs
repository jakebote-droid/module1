using System;

namespace module1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("Welcome to Jake's area of a shape calculator!");
                Console.WriteLine("");
                Console.WriteLine("Choose a shape to calculate its area we can do");
                Console.WriteLine("1. Circles");
                Console.WriteLine("2. Triangles");
                Console.WriteLine("3. Rectangles");
                Console.WriteLine("4. Squares");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CircleArea();
                        break;
                    case "2":
                        TriangleArea();
                        break;
                    case "3":
                        RectangleArea();
                        break;
                    case "4":
                        SquareArea();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;

                }

            }





        }

        public static void CircleArea()
        {
            //take user imput
            Console.Write("Enter the radius of the circle in inches: ");
            string input = Console.ReadLine();

            // Convert input to a double
            double radius;
            if (double.TryParse(input, out radius))
            {
                //math if valid imput
                double area = Math.PI * radius * radius;
                Console.WriteLine($"The area of the circle is: {area}in²");
            }
            else
            {
                //response if not valid
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }



        public static void TriangleArea()
        {
            //take user imput
            Console.Write("enter the base of the triangle in inches: ");
            string baseLength = Console.ReadLine();

            Console.Write("enter the height of the triangle in inches: ");
            string height = Console.ReadLine();

            // Convert input to a double
            double bottom;
            if (double.TryParse(baseLength, out bottom))
            {
                //we do nothing here this is just to convert to string to double
            }
            else
            {
                //response if not valid
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }


            double height2;
            if (double.TryParse(height, out height2))
            {
                //math if valid input
                double area = bottom * height2 / 2;
                Console.WriteLine($"The area of the triangle is: {area}in²");
            }
            else
            {
                //response if not valid
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            
        }

        public static void RectangleArea()
        {
            //take user input
            Console.Write("enter the length of the Rectangle in inches: ");
            string length = Console.ReadLine();

            Console.Write("enter the height of the Rectangle in inches: ");
            string width = Console.ReadLine();

            // Convert input to a double
            double length2;
            if (double.TryParse(length, out length2))
            {
                //we do nothing here this is just to convert to string to double
            }
            else
            {
                //response if not valid
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }


            double width2;
            if (double.TryParse(width, out width2))
            {
                //math if valid input
                double area = length2 * width2;
                Console.WriteLine($"The area of the Rectangle is: {area}in²");
            }
            else
            {
                //response if not valid
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }

          
        }
        public static void SquareArea()
        {
            //take user input
            Console.Write("Enter the radius of the circle in inches: ");
            string input = Console.ReadLine();

            // Convert input to a double
            double side;
            if (double.TryParse(input, out side))
            {
                //math if valid input
                double area = side * side;
                Console.WriteLine($"The area of the square is: {area}in²");
            }
            else
            {
                //response if not valid
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

    }
}   
    
