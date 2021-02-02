using System;

namespace Geometry
{
    public class Point : IReflectable
    {
        public readonly decimal X;
        public readonly decimal Y;

        public Point(decimal x)
        {
            this.X = x;
            this.Y = 0;
        }

        public Point(decimal x, decimal y)
        {
            this.X = x;
            this.Y = y;
        }

        public void ReflectX()
        {
            decimal x = 1;
            Point A = new Point(x);
        }

        public void ReflectY()
        {
            decimal x = 1, y = 1;
            Point A = new Point(x,y);
        }
    }
}
