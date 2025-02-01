using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Prompt
{
    public List<string> _prompts;

    public void PromptGenerator()
    {
        //accesses csv file(or .md file?) for prompts
        
        //make a random number generator

        //have it select a prompt equal to the index of a particular item in list
        
    }
    
    public void Display()
    {
        foreach (string pr in _prompts)
        {
            Console.WriteLine($"{_prompts}");

        }
    }
}