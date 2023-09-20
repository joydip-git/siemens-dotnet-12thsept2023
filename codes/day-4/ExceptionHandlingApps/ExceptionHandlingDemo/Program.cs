using System;

namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main()
        {
            int first = 10;
            int second = 0;
            int res = 0;
            int[] arr = new int[3];

            try
            {
               
                for (global::System.Int32 i = 0; i < arr.Length + 1; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception Type: {ex.GetType().Name}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Application: {ex.Source}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                //Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Type: {ex.GetType().Name}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Application: {ex.Source}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                //Console.WriteLine(ex);
            }
            finally
            {
                try
                {
                    Console.WriteLine(res);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            try
            {
                res = first / second;

                /*
                 * DivideByZeroException ex = new DivideByZeroException("Attempt to divide by zero");
                 * 
                 */
                Console.WriteLine(res);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception Type: {ex.GetType().Name}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Application: {ex.Source}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                //Console.WriteLine(ex);
            }
            finally
            {

            }
        }
    }
}
