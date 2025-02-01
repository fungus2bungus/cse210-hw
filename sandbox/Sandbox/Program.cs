using System;

class Program
{
    /* static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add new Job");
            Console.WriteLine("2. Display resume");
            Console.WriteLine("3. Quit");
            Console.WriteLine();
        } */
    static void Main(string[] args)
    {
        /* Resume theResume = new Resume(); 
        bool keepRunning = true;

        while (keepRunning)
        {
            DisplayMenu();

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // add a new job
                Console.Write("What is the name of the company? ");
                string company = Console.ReadLine();
                
                Console.Write("What is the position? ");
                string position = Console.ReadLine();
                
                Job newJob = new Job();
                newJob._company = company;
                newJob._jobTitle= position;
                newJob._startYear = 2015;
                newJob._endYear = 2023;
                Console.Write($"{newJob}");

                theResume._jobs.Add(newJob);

            }
            else if (choice == "2")
            {
                // Display the resume
                Console.WriteLine($"{theResume}");
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

        } */

/*         // int name = "John";

        Movie favoriteMovie = new();
        {
            favoriteMovie._title = "Star Wars";
            favoriteMovie._year = 1977;
            favoriteMovie._runtime = 150;
            favoriteMovie._rating = "PG";
        }

        Movie otherMovie = new();
        {
            otherMovie._title = "Avatar";
            otherMovie._year = 2009;
            otherMovie._runtime = 162;
            otherMovie._rating = "PG-13";
        }
        
        List<Movie> movies = new List<Movie>();
        movies.Add(favoriteMovie);
        movies.Add(otherMovie);
        
        foreach (Movie m in movies) 
        {
            m.Display();
        }
        
        // Console.WriteLine(favoriteMovie._title);
        favoriteMovie.Display();
        DisplayMovie(favoriteMovie);
        DisplayMovie(otherMovie);

        static void DisplayMovie(Movie aMovie)
        {
            Console.WriteLine($"{aMovie._title} - {aMovie._year}");
        } */
    }
}