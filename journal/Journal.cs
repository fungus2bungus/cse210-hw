using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _textEntries = new List<string>();
    public void Display()
    {
        for (int i=0; i < _entries.Count(); i++)
        Console.WriteLine($"{_entries[i]}");
    }
    
    public void FileRead()
    {
        string fileName = "promptlist.md";
        string[] lines = File.ReadAllLines(fileName);

        // foreach (string ld in lines)
        // {
        //     Console.WriteLine($"{ld}");
        // }
    }
    
    public void AddEntry(Entry en)
    {
        _entries.Add(en);
    }

    public void DisplayAllEntries()
    {
        //Entry.Display();
       // Needs to call Entry.Display and then iterate through each 
       // 
       int cn = 0;
    //    string jtext = "";
    //    foreach(Entry en in _entries)
        // {
            // cn+=1;
            // Console.WriteLine("");
            // Console.WriteLine($"Entry {cn}");
            // Console.WriteLine(en.Display());
            // Console.WriteLine(en._response);
            // jtext = $"{en._author} {en._date} {en._prompt} {en._response}";
            // jtext = Console.ReadLine();
            // _textEntries.Add(jtext);
        // }
       
        int cnt = 1;
       // Alternative only using strings
       for(int i = 0; i < _textEntries.Count()/2; i++)
       {
            int j = i+1;
            Console.WriteLine("");
            Console.WriteLine($"Entry {j}");
            Console.WriteLine(_textEntries[i+cn]);
            Console.WriteLine(_textEntries[i+cnt]);
            // else if(j % 2 >= 1)
            // {
            //     Console.WriteLine(_textEntries[j+1]);
            //     Console.WriteLine(_textEntries[j+2]);
            // }
            cnt+=1;
            cn+=1;
       }

    }
    
    public void UpdateTextEntries()
    {
        string jtext = "";
        // maybe having this as a for loop doesn't really help
        // or I could clear it here?
        // but also can't do that because _entries is cleared on relaunch, I need to be able to access everything from a fresh start, only through strings...
        foreach(Entry en in _entries)
        {
            _textEntries.Clear();
            // jtext = $"{en._date} {en._prompt} {en._response}";
            // _textEntries.Add(jtext);

            // jtext = $"Date: {en._date} Prompt: {en._prompt}";
            // jtext = $"{en._date}"

            // _textEntries.Add(jtext);
/*             _textEntries.Add(en._date);
            _textEntries.Add(en._prompt);
            _textEntries.Add(en._response);
            _textEntries.Add(" "); */

            _textEntries.Add(en.Display());
            _textEntries.Add(en._response);
        }
    }
}