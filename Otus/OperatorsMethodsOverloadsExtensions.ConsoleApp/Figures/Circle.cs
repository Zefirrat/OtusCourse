using System.Drawing;
using OperatorsMethodsOverloadsExtensions.ConsoleApp.Extensions;

namespace OperatorsMethodsOverloadsExtensions.ConsoleApp.Figures
{
    public class Circle
    {
        public Point Point;
        public int Radius;

        public Circle(int x, int y, int r)
        {
            Point = new Point(x, y);
            Radius = r;
        }

        public Circle(Point point, int r) : this(point.X, point.Y, r)
        {
        }

        public static bool operator >(Circle circle1, Circle circle2)
        {
            return circle1.Radius > circle2.Radius;
        }

        public static bool operator <(Circle circle1, Circle circle2)
        {
            return !(circle1 > circle2);
        }
    }
}