using System;

namespace JaggedArrayAndParamsDemo
{
    internal class Program
    {
        //params int[] ints;
        static void UseJaggedArray()
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
        static void JaggedTask()
        {
            Console.Write("enter size of the jaggaed array: ");
            int size = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[size][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"enter size of the new array#{i} in jagged arry: ");
                int length = int.Parse(Console.ReadLine());
                int[] single = new int[length];
                jaggedArray[i] = single;
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"\nenter values in the array#{i} in the jagged array\n");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"enter value at jagged[{i}][{j}]: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            int index = 0;
            foreach (int[] single in jaggedArray)
            {
                Console.WriteLine($"\ndisplaying values from the array#{index} in the jagged array\n");
                int singleIndex = 0;
                foreach (var item in single)
                {
                    Console.WriteLine($"value at jagged[{index}][{singleIndex}]: {item}");
                    singleIndex++;
                }
                index++;
            }
        }

        //parameter array: an array declared with params keyword as part of the function argument
        //any array which is declared as local variable or data member of a class, can not be declared with params keyword
        //you can have only one array with params keyword as part of any function argyment list
        //the parameter array should be the last in the fucntion argument
        static void SplitSentence(string sentence, params char[] delimiters)
        {
            // params int[] ints = new int[sentence.Length];
        }
        
        static void Main()
        {
            //UseJaggedArray();
            //JaggedTask();
            Console.Write("enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(',', '.', '!', ' ');
            SplitSentence(sentence);
            //SplitSentence(sentence, ' ', '.', ',');
            //SplitSentence(sentence, ' ', '.', ',', '!');

            Console.WriteLine("press any key to terminate...");
            Console.ReadKey();
        }
    }
}
