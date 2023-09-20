using System;

namespace CustomExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Applicant sunilApplicant = new Applicant();
                sunilApplicant.Name = "Sunil";
                sunilApplicant.Age = 17;
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.ExceptionLoggedTime);
            }
        }
    }
}
