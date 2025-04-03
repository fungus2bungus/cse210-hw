using System;
using System.Collections.Generic;

class Program
{
    static void MenuDisplay()
    {
        Console.WriteLine($"1. Write a new entry");
        Console.WriteLine($"2. Display the journal");
        Console.WriteLine($"3. Save the journal to a file");
        Console.WriteLine($"4. Load journal from file");
        Console.WriteLine($"5. Exit");
        Console.Write($"Select action: ");
    }
    static void Main(string[] args)
    {
        //here be where the code be

        //first display options/prompt
        // entry1.Display();
        // set up for author
        // Console.Write($"Input Author Name: ");
        // instead have this just assigned to a global(local?) variable
        // entry1._author = Console.ReadLine();
        // string author = Console.ReadLine();
        string author = "Conner";
        Journal journal1 = new Journal();

        List<string> entries = new List<string>();
        Prompt scorp = new Prompt();
        // string textcontent = "";
        string m = "";

        while(m != "5")
            {

                if(m == "1")
                {
                    Entry entry1 = new Entry(author, scorp.PromptGenerator());
                    // entry1._author = author;
                    // Console.WriteLine($"Write entry selected");
                    // entry1._prompt = scorp.PromptGenerator();
                    // entry1._prompt = Console.ReadLine();
                    Console.Write("> ");
                    entry1.UserInput();
                    // entries.Add(entry1._response);
                    // journal1.AddEntry(entry1);
                    journal1._entries.Add(entry1);
                    journal1._textEntries.Add(entry1.Display());
                    journal1._textEntries.Add(entry1._response);
                }
                else if(m =="2")
                {
                    // dispay method from Journal
                    journal1.DisplayAllEntries();

                  /*   foreach(string en in entries)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"{en}");
                    } */
                }
                else if(m =="3")
                {
                    // TODO: save the entries to the journal
                    // okay, maybe I should have it so that it stores the whole journal to a file
                    Console.Write("Choose a filename: ");
                    string fpath = @"C:\Users\Cortex\Documents\cdporje\cse210-hw\journal\jornels\" + Console.ReadLine() + ".txt";
                    
                    // journal1.UpdateTextEntries();
                    string jortext = "";
                    // File.WriteAllText(fpath, author);
                    
                    foreach(string sp in journal1._textEntries)
                    {
                        // Console.WriteLine("");
                        // Console.WriteLine(sp);
                        // Console.WriteLine(journal1._textEntries.Count());
                        jortext = jortext+sp+" ";
                        // File.AppendAllText(fpath, jortext);
                    }
                    // entries.Add(" ");
                    // File.AppendAllLines(fpath, entries);
                    File.AppendAllLines(fpath, journal1._textEntries);
                    // journal1._textEntries.Clear();

                }
                else if(m =="4")
                {
                    Console.Write("Enter file name: ");
                    string filename = @"C:\Users\Cortex\Documents\cdporje\cse210-hw\journal\jornels\" + Console.ReadLine() + ".txt";
                    string content = File.ReadAllText(filename);
                    List<string> jorcont = new List<string>(File.ReadAllLines(filename));
                    // jorcont = File.ReadAllText(filename);
                    journal1._textEntries.Clear();
                    foreach(string cont in jorcont)
                    {
                        journal1._textEntries.Add(cont);
                    }

                    // okay... now I need to add everything to journal/overwrite it
                    // journal1._entries.Clear();
                    // Entry entry2 = new Entry(author, scorp.PromptGenerator());
                    // so I need to re-add everything to each entry, then add that to entries
                    // I just need to focus on the strings, not the classes... ugh


                    // Console.WriteLine("");
                    // Console.WriteLine(content);
                    // Console.WriteLine(jorcont);
                }
                Console.WriteLine("");
                MenuDisplay();

                m = Console.ReadLine();
            }

        // Journal journal1 = new Journal();
        // {
            //entries from entry?
            // journal1._entries = new List<string> {"man", "bam"};
        // }
        journal1.FileRead();
    }
    
}