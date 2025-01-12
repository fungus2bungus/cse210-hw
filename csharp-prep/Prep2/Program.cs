using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        int aGr = 90;
        int bGr = 80;
        int cGr = 70;
        int dGr = 60;

        Console.Write($"What is your grade percentage? ");
        string grRString = Console.ReadLine();
        int grRep = int.Parse(grRString);
        string letter = "";

        if (grRep >= aGr) {
            letter = "A";
        }
        else if (grRep >= bGr) {
            letter = "B";
        }
        else if (grRep >= cGr) {
            letter = "C";
        }
        else if (grRep >= dGr) {
            letter = "D";
        }
        else if (grRep < dGr) {
            letter = "F";
        }
        Console.WriteLine($"You received a: {letter}");
        
        if (grRep >= cGr) {
            Console.WriteLine($"Congradulations, you have passed.");
        }
        else {
            Console.WriteLine($"You have not passed.");
        }
    }
}