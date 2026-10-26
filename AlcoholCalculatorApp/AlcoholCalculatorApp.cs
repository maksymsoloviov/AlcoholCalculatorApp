namespace AlcoholCalculatorApp
{
    public class AlcoholCalculator
    {
        public double CalculateDrinkVolume(
            double glassVolume, int count)
        {
            return glassVolume * count;
        }
        public double CalculatePureAlcohol(
            double glassVolume, double alcoholPercent, int count)
        {
            return glassVolume * count * alcoholPercent / 100;
        }
    }
}