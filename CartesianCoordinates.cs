using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int size, params Point[] points)
        {
            if (points == null)
                throw new ArgumentNullException();
            if (points.Length == 0 || size<=0)
                throw new ArgumentException();
            List<Point> otv = new List<Point>();
            for (int i = 0; i < points.Length; i++)
            {
                if (Math.Abs(point.X - points[i].X) <= size && Math.Abs(point.Y - points[i].Y) <= size)
                    otv.Add(points[i]);
            }
            return (otv);
        }
    }
}
