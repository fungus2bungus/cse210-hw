using System;

class Program
{
     static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add new Job");
            Console.WriteLine("2. Display resume");
            Console.WriteLine("3. Quit");
            Console.WriteLine();
        }
    static void Main(string[] args)
    {
        Resume theResume = new Resume(); 
        Console.Write($"Enter your name (First Last): ");
        theResume._name = Console.ReadLine();

        bool keepRunning = true;

        while (keepRunning)
        {
            DisplayMenu();

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            if (choice == "1")
            {
                // add a new job
                Console.Write("What is the name of the company? ");
                string company = Console.ReadLine();
                
                Console.Write("What is the position? ");
                string position = Console.ReadLine();
                
                Console.Write($"What is the start year? ");
                int yearStart = int.Parse(Console.ReadLine());

                Console.Write($"What is the end year? ");
                int yearEnd = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Job newJob = new Job();
                newJob._company = company;
                newJob._jobTitle= position;
                newJob._startYear = yearStart;
                newJob._endYear = yearEnd;
                Console.Write($"{newJob}");

                theResume._jobs.Add(newJob);

            }
            else if (choice == "2")
            {
                // Display the resume
                theResume.DisplayResumeDetails();
                Console.WriteLine("");
            }
            else if (choice == "3")
            {
                // Quit
                keepRunning = false;
            }
            else
            {
                // unexpected input
                Console.WriteLine("Sorry, that is not valid. Please try again.");
            }

        }
    }
}