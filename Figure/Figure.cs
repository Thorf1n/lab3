

using System.Drawing;

namespace Figure
{
    internal class Figure
    {
        private Point[] points;

        public Figure(params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
            {
                throw new ArgumentException("Polygon should have three to five coordinates");
            }
            this.points = points;
        }

        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                perimeter += GetSideLength(points[i], points[(i + 1) % points.Length]);
            }

            Console.WriteLine($"Perimeter: {perimeter}");

            if (points.Length == 3)
            {
                Console.WriteLine("Triangle");
            }
            else if (points.Length == 4)
            {
                Console.WriteLine("Quadrangle");
            }
            else if (points.Length == 5)
            {
                Console.WriteLine("Pentagon");
            }
        }
    }
}