using System;
namespace AlcoholCalculatorApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Alcohol Calculator");
            Console.WriteLine("------------------");
            Console.Write("Glass volume (ml): ");
            double volume = Convert.ToDouble(Console.ReadLine());
            Console.Write("Alcohol percentage (%): ");
            double percent = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of glasses: ");
            int count = Convert.ToInt32(Console.ReadLine());
            AlcoholCalculator calculator = new AlcoholCalculator();
            double drinkVolume =
                calculator.CalculateDrinkVolume(volume, count);
            double pureAlcohol =
                calculator.CalculatePureAlcohol(volume, percent, count);
            Console.WriteLine();
            Console.WriteLine("Results");
            Console.WriteLine("Total drink volume: " + drinkVolume + " ml");
            Console.WriteLine("Pure alcohol volume: " + pureAlcohol + " ml");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}