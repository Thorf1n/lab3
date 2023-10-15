using System.Drawing;

namespace Figure
{

    internal class Program
    {


        static void Main()
        {
            Console.WriteLine("Enter three to five coordinates for the polygon:");

            Console.Write("Count of ccordinates: ");
            int numberOfPoints = Convert.ToInt32(Console.ReadLine());

            if (numberOfPoints < 3 || numberOfPoints > 5)
            {
                Console.WriteLine("Incorrect number of coordinates.");
                return;
            }

            Point[] inputPoints = new Point[numberOfPoints];

            for (int i = 0; i < numberOfPoints; i++)
            {
                Console.Write($"Coordinate {i + 1} (x y): ");
                string[] coordinates = Console.ReadLine().Split(' ');
                double x = Convert.ToDouble(coordinates[0]);
                double y = Convert.ToDouble(coordinates[1]);
                inputPoints[i] = new Point(x, y);
            }

            Figure figure = new Figure(inputPoints);
            figure.CalculatePerimeter();
        }
    }
}
