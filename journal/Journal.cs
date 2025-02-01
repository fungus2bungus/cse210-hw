using System;
using System.Collections.Generic;

public class Journal
{
    public List<string> _entries;
    public void Display()
    {
        for (int i=0; i < _entries.Count(); i++)
        Console.WriteLine($"{_entries[i]}");
    }
}