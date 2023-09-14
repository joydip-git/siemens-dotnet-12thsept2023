using ShapeCalculatorApp.Shapes;
using System;

namespace ShapeCalculatorApp.Client
{
    internal class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("\n1. Calculate Area of circle");
            Console.WriteLine("2. Calculate Area of triangle");
        }
        static int GetChoice()
        {
            Console.Write("\nenter choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        static IShape CreateShape(int choice)
        {
            IShape shape;
            switch (choice)
            {
                case 1:
                    Console.Write("\nRadius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shape = new Circle(radius);
                    break;

                case 2:
                    Console.Write("\nBase: ");
                    double tBase = double.Parse(Console.ReadLine());
                    Console.Write("\nHeight: ");
                    double tHeight = double.Parse(Console.ReadLine());
                    shape = new Triangle(tBase, tHeight);
                    break;

                default:
                    shape = null;
                    break;
            }
            return shape;
        }
        static void Main()
        {
            PrintMenu();
            int choice = GetChoice();
            IShape shape = CreateShape(choice);
            Type shapeType = shape.GetType();
            //Type circleType = typeof(Circle);
            //Console.WriteLine($"Area of {shapeType.FullName} is {shape.CalculateArea()}");
            Console.WriteLine($"Area of {shapeType.Name} is {shape.CalculateArea()}");
        }
    }
}
