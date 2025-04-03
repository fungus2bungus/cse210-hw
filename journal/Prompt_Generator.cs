using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Prompt
{
    public List<string> _prompts;

    public string PromptGenerator()
    {
        //accesses csv file(or .md file?) for prompts
        
        //make a random number generator

        //have it select a prompt equal to the index of a particular item in list
        string fileName = "promptlist.md";
        string[] lines = File.ReadAllLines(fileName);
        
        Random random = new Random();
        int randindex = random.Next(0, lines.Length);
        
        Console.WriteLine(lines[randindex]);

        return lines[randindex];

        /* foreach (string ld in lines)
        {
            Console.WriteLine($"{ld}");:W

        } */

    }
    
    public void Display()
    {
        foreach (string pr in _prompts)
        {
            Console.WriteLine($"{_prompts}");

        }
    }
}