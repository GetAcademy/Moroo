using System;

namespace Moroo
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point();
            point.X = 5;
            point.Y = 10;
            point.X++;

            var doublePoint = Double(point);
            //Console.WriteLine("Hello World!");
            //foreach (var arg in args)
            //{
            //    Console.WriteLine(arg);
            //}
        }

        private static Point Double(Point point)
        {
            var newPoint = new Point();
            newPoint.X = point.X * 2;
            newPoint.Y = point.Y * 2;
            return newPoint
        }
    }
}
