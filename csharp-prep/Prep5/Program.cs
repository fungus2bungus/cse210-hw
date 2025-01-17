using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));

        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName() {
            Console.Write("Please enter your name: ");
            string tn = Console.ReadLine();
            return tn;
        }

        static int PromptUserNumber() {
            Console.Write("Please enter your favorite number: ");
            int fnv = int.Parse(Console.ReadLine());
            return fnv;
        }
        static int SquareNumber(int snum) {
            return snum*snum;
            
        }
        static void DisplayResult(string userName, int sqrn) {
            Console.WriteLine($"{userName}, the square of your number is {sqrn}");

        }

    }
}