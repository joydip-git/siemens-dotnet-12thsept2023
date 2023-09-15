using System;

namespace ParameterArrayExample
{
    internal class Program
    {
        static void CalculateAverage(string name, params double[] marks)
        {
            double sum = 0;
            if (marks != null && marks.Length > 0)
            {
                foreach (var mark in marks)
                {
                    sum += mark;
                }
                Console.WriteLine($"{name} has got average marks:{sum / marks.Length}");
            }
            else
                Console.WriteLine($"{name} has got average marks:0");
        }
        static void Main()
        {
            CalculateAverage("anil", 34, 56);
            CalculateAverage("sunil", 34, 56, 87, 78);
        }
    }
}
