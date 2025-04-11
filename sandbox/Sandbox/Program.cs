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
       // TODO start book thing? 
       Person p1 = new Person();
       p1.SetName("Jerry");
       p1.SetAge(23);
       
       p1.Display();
       
       string theName = p1.GetName();
       Console.WriteLine($"The person's name was: {theName}");
       
    //    Person p2 = new Person("Mary", 18);

        
/* 

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