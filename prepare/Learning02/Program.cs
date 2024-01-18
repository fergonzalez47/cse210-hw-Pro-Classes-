using System;

class Program
{
    static void Main(string[] args)
    {
    
        Job Job1 = new Job();
        Job1._jobTitle = "Software Engineer";
        Job1._company = "Microsoft";
        Job1._startyear = 2015;
        Job1._endYear = 2027;

        Job Job2 = new Job();
        Job2._jobTitle = "Engineer";
        Job2._startyear = 2010;
        Job2._endYear = 2020;
        Job2._company = "Apple";

        // Job1.Display();
        // Job2.Display();

        Resume resume = new Resume();
        resume._name = "Fernando Gonzalez";
        resume._jobs.Add(Job1);
        resume._jobs.Add(Job2);
        resume.Display();
    }

    
}