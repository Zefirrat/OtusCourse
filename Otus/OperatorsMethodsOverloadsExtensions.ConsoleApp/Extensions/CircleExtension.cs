using OperatorsMethodsOverloadsExtensions.ConsoleApp.Figures;

namespace OperatorsMethodsOverloadsExtensions.ConsoleApp.Extensions
{
    public static class CircleExtension
    {
        public static Circle Default(this Circle circle)
        {
            return new Circle(0, 0, 1);
        }

        public static string ConvertToString(this Circle circle)
        {
            return
                $"We have figure {nameof(Circle)} with cords: {circle.Point.ToString()} and radius: {circle.Radius.ToString()}";
        }
    }
}