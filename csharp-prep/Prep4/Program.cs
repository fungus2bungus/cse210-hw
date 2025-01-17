using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        int i = 1;
        List<int> mg = new List<int>();
        Console.WriteLine("Enter a list of Numbers, type 0 when finished.");
        while (i != 0) {
            Console.Write("Enter a number: ");
            int sd = int.Parse(Console.ReadLine());
            mg.Add(sd);
            if (sd == 0) {
                mg.Remove(0);
                i--;
            }
            
        }
        int k = 0;
        double ew = mg.Count;
        int jk = 0;
        int sm = 10;
        foreach (int nu in mg)
        {
            k += nu;
            if (nu > jk) {
                jk = nu;
            }
            if (nu < sm && nu > 0) {
                sm = nu;
            }
        }
        double avgs = k/ew;
        // Console.WriteLine(mg[1]);
        Console.WriteLine($"The sum is: {k}");
        Console.WriteLine($"The average is: {avgs}");
        Console.WriteLine($"The largest number is: {jk}");
        Console.WriteLine($"The smallest positive number is: {sm}");
        // Console.WriteLine($"The sorted list is: ");
        // int mh = 0;
        // foreach (int h in mg) 
        // {
        //     // make a brand new list that is ordered properly, then Console.WriteLine() each variable
        //     // mh = mg[h];
        //     Console.WriteLine(h);
        // }
    }
}