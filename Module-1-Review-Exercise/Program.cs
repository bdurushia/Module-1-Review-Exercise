namespace Module_1_Review_Exercise
{
    internal class Program
    {

        static double GetCircleArea(double radius)
        {
            double circleArea = Math.PI * radius * radius;
            return circleArea;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter your circle radius number:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of the circle that has a radius of {radius} is {GetCircleArea(radius)}");

            Console.WriteLine("Press any key to exit the application.");
            Console.ReadKey();
        }
    }
}
