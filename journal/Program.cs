using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //here be where the code be

        //first display options/prompt
        Entry entry1 = new Entry();
        entry1.Display();
        entry1.UserInput();

        Journal journal1 = new Journal();
        {
            //entries from entry?
            journal1._entries = new List<string> {"man", "bam"};
        }
        journal1.Display();
    }
    
}