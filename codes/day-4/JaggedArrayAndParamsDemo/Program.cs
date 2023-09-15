using System;

namespace JaggedArrayAndParamsDemo
{
    internal class Program
    {
        static void Main()
        {
            //int[] numbers = new int[] { 1, 2, 3 };
            //int[] numbers = { 1, 2, 3 };
            //int[,] twoDimArray = { { 2, 3 }, { 5, 6 }, { 7, 8 } };
            string[] names = new string[] { "anil", "sunil" };

            int[] first = { 1, 2, 3 };
            int[] second = { 4, 5, 6, 7, 8 };
            //Jagged Arrays: array of arrays
            int[][] jagged = new int[2][];

            jagged[0] = first;
            jagged[1] = second;

            int[,] firstTwoDim = { { 1, 2 }, { 3, 4 } };
            int[,] secondTwoDim = { { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            int[][,] jaggedTwoDim = new int[2][,];
            jaggedTwoDim[0] = firstTwoDim;
            jaggedTwoDim[1] = secondTwoDim;
        }
    }
}
