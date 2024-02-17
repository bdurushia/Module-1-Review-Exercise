namespace Module_1_Review_Exercise
{
    internal class Program
    {

        static double GetCircleArea(double radius)
        {
            // This method takes in the user given radius and uses Math.PI to calculate the area of the circle
            double circleArea = Math.PI * radius * radius;
            // return the calculated area of the circle
            return circleArea;
        }

        static double GetTriangleArea(double baseLength, double height)
        {
            // A = ( hb * b ) / 2
            double triangleArea = (height * baseLength) / 2;
            return triangleArea;

        }
        static double GetRectangleArea(double length, double width)
        {
            // Calculate area of a rectangle
            double rectangleArea = length * width;
            return rectangleArea;
        }

        static double GetSquareArea(double side)
        {
            double squareArea = side * side;
            return squareArea;
        }

        public static void UserChoices()
        {
            Console.WriteLine("Choose (type in) which shape area you want to calculate: circle, triangle, rectangle, or square:");
            string userChoice = Console.ReadLine().ToLower().Trim();

            switch (userChoice)
            {
                case "circle":

                    // AREA OF CIRCLE
                    // Ask user for a radius of a circle, listen for user data and convert it to a double
                    Console.WriteLine("\nPlease enter your circle radius number:");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    // Calls circle area method and writes calculated area to console
                    Console.WriteLine($"\nThe area of your circle is {GetCircleArea(radius)}.\n");
                    break;

                case "triangle":

                    // AREA OF TRIANGLE
                    // Ask for height of triangle, convert to double and store it
                    Console.WriteLine("\nPlease enter the height of your triangle:");
                    double height = Convert.ToDouble(Console.ReadLine());

                    // Ask for base length of triangle, convert to double and store it
                    Console.WriteLine("Please enter the base length of your triangle:");
                    double baseLength = Convert.ToDouble(Console.ReadLine());

                    // Call triangle method and print out the calculated area of the triangle
                    Console.WriteLine($"\nThe area of your triangle is {GetTriangleArea(height, baseLength)}.\n");
                    break;

                case "rectangle":

                    // AREA OF RECTANGLE
                    Console.WriteLine("\nPlease enter the length of your rectangle:");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the width of your rectangle:");
                    double width = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"\nThe area of your rectangle is {GetRectangleArea(length, width)}.\n");
                    break;

                case "square":

                    // AREA OF A SQUARE
                    // Ask user for the measurement of the side of their square and store it
                    Console.WriteLine("\nPlease enter the length of one side of your square:");
                    double side = Convert.ToDouble(Console.ReadLine());

                    // Call method to calculate square area and write it to the console
                    Console.WriteLine($"\nThe area of your square is {GetSquareArea(side)}.");
                    break;

            }
            // Ensures user can exit the CLI application after everything is done or choose to make another calculation
            Console.WriteLine("\nWould you like to calculate another shape's area?\nType 'Y' to choose again or 'Q' to quit:");
            string chooseAgain = Console.ReadLine().ToLower().Trim();

            if (chooseAgain == "y")
            {
                Console.Clear();
                UserChoices();
            }
            else if (chooseAgain != "y")
            {
                Console.Clear();
                Console.WriteLine("Thanks for using the Shape-Area Calculator! Goodbye!");
            }
        }
        static void Main(string[] args)
        {
            // Start application by welcoming user and immediately prompting the choice list
            Console.WriteLine("Welcome to the Shape-Area Calculator!\n");
            UserChoices();
        }
    }
}
