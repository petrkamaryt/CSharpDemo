using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class Person
    {
        private double _weightKg;
        private double _heightCm;

        public double WeightKg
        {
            get { return _weightKg; }
            set
            {
                if (value < 2 || value > 300)
                {
                    throw new ArgumentException("Weight must be between 2kg and 300kg.");
                }
                _weightKg = value;
            }
        }
        
        public double HeightCm
        {
            get { return _heightCm; }
            set 
            {
                if (value < 30 || value > 250)
                {
                    throw new ArgumentException("Height must be between 30 and 250 cm.");
                }
                _heightCm = value;
            }
        }

        public double BMI
        {
            get
            {
                double heightM = HeightCm / 100;
                return WeightKg / (heightM * heightM);
            }
        }

        public string GetCategory()
        {
            double bmi = BMI;
            if (bmi < 18.5)
                return "Underweight! Eat something!";
            else if (bmi < 25)
                return "Normal weight! Great job!";
            else if (bmi < 30)
                return "Overweight! Make some exercises!";
            else
                return "Obesity!";
        }

        public void PrintReport()
        {
            Console.WriteLine("\n---BMI Report---");
            Console.WriteLine($"Weight: {WeightKg} kg");
            Console.WriteLine($"Hight: {HeightCm} cm");
            Console.WriteLine($"BMI {BMI:f2}");
            Console.WriteLine($"Category: {GetCategory()}");
        }
    }
}
