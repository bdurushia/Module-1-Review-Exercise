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
        static void Main(string[] args)
        {
            // AREA OF CIRCLE
            // Ask user for a radius of a circle, listen for user data and convert it to a double
            Console.WriteLine("Please enter your circle radius number:");
            double radius = Convert.ToDouble(Console.ReadLine());
            // Calls circle area method and writes calculated area to console
            Console.WriteLine($"The area of your circle is {GetCircleArea(radius)}.\n");

            // AREA OF TRIANGLE
            // Ask for height of triangle, convert to double and store it
            Console.WriteLine("Please enter the height of your triangle:");
            double height = Convert.ToDouble(Console.ReadLine());
            // Ask for base length of triangle, convert to double and store it
            Console.WriteLine("Please enter the base length of your triangle:");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            // Call triangle method and print out the calculated area of the triangle
            Console.WriteLine($"The area of your triangle is {GetTriangleArea(height, baseLength)}.\n");

            // AREA OF RECTANGLE
            Console.WriteLine("Please enter the length of your rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width of your rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of your rectangle is {GetRectangleArea(length, width)}.\n");

            // Ensures user can exit the CLI application after everything is done
            Console.WriteLine("\nPress any key to exit the application.");
            Console.ReadKey();
        }
    }
}
