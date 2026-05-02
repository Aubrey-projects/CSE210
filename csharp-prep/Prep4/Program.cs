using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>{};
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;

        do
        {
            Console.Write("Enter number: ");
            string numberString = Console.ReadLine();
            number = int.Parse(numberString);
            numbersList.Add(number);

        } while (number != 0);

        int sum = 0;
        double amountOfNumbers = -1;
        int largestNumber = 0;
        foreach (int i in numbersList)
        {
            sum += i;
            amountOfNumbers++;

            if (i > largestNumber)
            {
                largestNumber = i;
            }
        }
        double average = sum/amountOfNumbers;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}