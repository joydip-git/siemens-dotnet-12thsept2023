using System;

namespace ArrayDemo
{
    internal class Program
    {
        static void SimpleArray()
        {
            //Array numbers = new Array();
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("enter value at index-" + i + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("value at numbers[" + i + "]: " + numbers[i]);
            //}
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        static void TwoDimensionalDemo()
        {
            int[,] ints = new int[3, 3];
        }
        static void Main()
        {
            int length = GetLength();
            int[] numbers = new int[length];

            EnterValuesInTheArray(numbers);
            PrintMenu();
            int choice = GetChoice();
            SortArray(numbers, choice);
            PrintArrayValues(numbers);
        }
        static int GetLength()
        {
            Console.Write("enter size of the array: ");
            return int.Parse(Console.ReadLine());
        }
        static void EnterValuesInTheArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = GetValue(i);
            }
        }
        static int GetValue(int index)
        {
            Console.Write("enter value for index-" + index + ": ");
            return int.Parse(Console.ReadLine());
        }
        static void PrintMenu()
        {
            Console.WriteLine("1. sort array in ascending order");
            Console.WriteLine("2. sort array in descending order");
        }
        static int GetChoice()
        {
            Console.Write("\nenter choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        static void SortArray(int[] arr, int sortChoice)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {                    
                    switch (sortChoice)
                    {
                        case 1:
                            if( arr[i] > arr[j])
                            {
                                int temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }
                            break;

                        case 2:
                            if (arr[j] > arr[i])
                            {
                                int temp = arr[j];
                                arr[j] = arr[i];
                                arr[i] = temp;
                            }
                            break;

                        default:
                            break;
                    }
                }
            }

        }        
        static void PrintArrayValues(int[] numbers)
        {
            Console.WriteLine("\nafter sorting\n");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
