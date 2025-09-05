using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the BMI Calculator!\n");

            try
            {
                Person person = new Person();

                Console.WriteLine("Enter your weight in kg: ");
                person.WeightKg = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your height in cm: ");
                person.HeightCm = Convert.ToDouble(Console.ReadLine());

                person.PrintReport();
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine($"Input error: {ex.Message}");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Error: Please enter valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occured: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}