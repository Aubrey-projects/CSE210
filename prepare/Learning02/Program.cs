using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1988;
        job1._endYear = 2022;

        Console.WriteLine(job1._company);
        Console.WriteLine(job1._jobTitle);

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2003;
        job2._endYear = 2018;

        Console.WriteLine(job2._company);
        Console.WriteLine(job2._jobTitle);
        

        
    }
}