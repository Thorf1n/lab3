﻿
namespace Figure
{
    internal class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
