using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberAsString = Console.ReadLine();
        return int.Parse(numberAsString);
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        string birthString = Console.ReadLine();
        birthYear = int.Parse(birthString);
    }

    static int SquareNumber(int number)
    {
        return (int)Math.Pow(number, 2);
    }

    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        int ageThisYear = 2026 - birthYear;

        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        Console.WriteLine($"{name}, you will turn {ageThisYear} this year");
    }
    
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber, birthYear);
    }
}