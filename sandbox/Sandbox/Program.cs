using System;

class Program
{
    // void is the type of data it returns
    static void DisplayGreeting()
        {
            Console.WriteLine("Hello Betty");
        }

    static double AddNumbers(int n1, int n2, double n3)
    {
        double total = n1 + n2 + n3;
        return total;
    }

    static void Main(string[] args)
    {
        /* FIRST DAY
        Console.WriteLine("Hello Sandbox World!");

        int x = 10;
        if (x == 11) // <-- Do not put semi colons here! It WILL run the code block even if the statement is false.
        {
            Console.WriteLine("Hey Bob"); // if the code block is ONLY 1 LINE, then technically you do not need {}
        }
        
        // This for loop counts 0-9
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 20; i > -20; i -= 2)
        {
            Console.WriteLine(i);
        }

        // while loop (needs enterance strategy)
        int age = 0;
        while (age <= 0 || age > 125)
        {
            Console.WriteLine("Please enter your age: ");
            age = int.Parse(Console.ReadLine());
        }

        // do while loop (no enterance strategy)
        int age2;
        do
        {
            Console.WriteLine("Please enter your age: ");
            age2 = int.Parse(Console.ReadLine());
        } while (age2 <= 0 || age2 > 125);
        */

        for (int i = 0; i <= 32; ++i)
        {
            // int is centered at 0, and can go from 2 billion to -2 billion
            // uint is not centered at 0, it cannot be negative it goes to 4 billion
            uint powerNumber = (uint)Math.Pow(2, i);
            Console.Write($"2 to the power of {i}, is {powerNumber}");
            Console.WriteLine($", 0x{powerNumber.ToString("X")}"); //hexadecimal
        }

        // the new opperator goes and allocates a new object
        List<int> myData = new List<int>{}; // Creates a list of integers
        myData.Add(1);
        myData.Add(2);
        myData.Add(3);
        myData.Add(4);
        myData.Add(5);
        myData.Add(99);
        myData.Add(-100);

        foreach(int i in myData)
        {
            Console.WriteLine(i);
        }

        DisplayGreeting();
        double total = AddNumbers(10, 20, 1001.234);
        Console.WriteLine(total);
    }
}