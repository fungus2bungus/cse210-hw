using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // double x = 11.0 / 3.0;
        // Console.WriteLine(x);
        //int k;
        int i = 0;
        int gn;
        string rp = "yes";
        while (rp == "yes") {
            Random random = new Random();
            int mn = random.Next(1,100);
            do {
                // Console.Write("What is the magic number? ");
                // int mn = int.Parse(Console.ReadLine());
                Console.Write("What is your guess? ");
                gn = int.Parse(Console.ReadLine());
                // Console.WriteLine(mn);
                if (gn > mn) {
                    Console.WriteLine("Lower");
                }
                else if (gn == mn) {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You made {i} guesses");
                    i = 0;
                    Console.Write("Would you like to play again(yes or no)? ");
                    rp = Console.ReadLine();
                }
                else {
                    Console.WriteLine("Higher");
                }
                i++;
                } while (gn != mn);
        }        
    }
}