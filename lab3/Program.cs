

namespace Rectangle

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the first side of rectangle:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side of rectangle:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Perimeter of the rectangle: {rectangle.Perimeter}");
            Console.WriteLine($"Area of the rectangle: {rectangle.Area}");

            Console.ReadLine();
        }


    }
}
