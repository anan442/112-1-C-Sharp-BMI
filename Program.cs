using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter height (cm) : ");
            float height_cm = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter weight (kg) : ");
            int weight = int.Parse(Console.ReadLine());

            float height_m = height_cm / 100;
            float bmi = weight / (height_m * height_m);

            if (bmi < 18.5)
            {
                Console.WriteLine("Your BMI: " + bmi +", underweight.");
            }
            else if(18.5 <= bmi && bmi <= 24)
            {
                Console.WriteLine("Your BMI: " + bmi + ", normal.");
            }
            else if (bmi > 24)
            {
                Console.WriteLine("Your BMI: " + bmi + ", overweight.");
            }

            Console.ReadKey();
        }
    }
}
