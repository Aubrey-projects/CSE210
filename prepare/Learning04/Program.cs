using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(myAssignment.GetSummary());
    }
}