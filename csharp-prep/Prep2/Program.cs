using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (Enter as a whole number without a % symbol): ");
        string gradePercentageInText = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageInText);
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade: {letter}");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you pass!");
        }
        else if (gradePercentage < 70)
        {
            Console.WriteLine("We regret to inform you that you did not pass. Try again next semester!");
        }
    }
}