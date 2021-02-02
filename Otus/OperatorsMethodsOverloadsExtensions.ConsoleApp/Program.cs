using System;
using OperatorsMethodsOverloadsExtensions.ConsoleApp.Extensions;
using OperatorsMethodsOverloadsExtensions.ConsoleApp.Figures;

namespace OperatorsMethodsOverloadsExtensions.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = new Circle(10, 5, 2);
            var figure2 = figure.Default();

            Console.WriteLine($"Figure1: {figure.ConvertToString()}");
            
            Console.WriteLine($"Figure2: {figure2.ConvertToString()}");
            
            Console.WriteLine($"Figure1>Figure2: {figure>figure2}");
            Console.WriteLine($"Figure1<Figure2: {figure<figure2}");
            
            Console.ReadLine();
        }
    }
}