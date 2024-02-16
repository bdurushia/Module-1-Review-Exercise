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
        static void Main(string[] args)
        {
            // Ask user for a radius of a circle, listen for user data and convert it to a double
            Console.WriteLine($"Please enter your circle radius number:");
            double radius = Convert.ToDouble(Console.ReadLine());
            // Calls circle area method and writes calculated area to console
            Console.WriteLine($"The area of the circle that has a radius of {radius} is {GetCircleArea(radius)}");

            // Ensures user can exit the CLI application after everything is done
            Console.WriteLine("Press any key to exit the application.");
            Console.ReadKey();
        }
    }
}
