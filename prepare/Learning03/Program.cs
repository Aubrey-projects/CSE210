using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 20; i++)
        {
            Fraction fraction = new Fraction();
            Random randomGenerator = new Random();

            int randomNumerator = randomGenerator.Next(1, 10);
            fraction.SetNumerator(randomNumerator);
            int randomDenominator = randomGenerator.Next(1, 10);
            fraction.SetDenominator(randomDenominator);

            string fractionString = fraction.GetFractionString();
            double fractionDecimal = fraction.GetDecimalValue();
            
            Console.WriteLine($"Fraction {i + 1}: String: {fractionString} Number: {fractionDecimal}");
        }
        
    }
}