class Listing : Activity
{
    public Listing()
    {
        _startingmsg="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _name="Listing";
    }

    private List<string> _prompts = new List<string>();
    // i don't remember why I need a list of the prompts? maybe it would've been easier than using a file?
    // yeah it was, I'm still leaving this in to show my thought process

    // private function of GetPromptList() that returns a list 
    // makes a list Add() s a bunch of prompts and returns the list
    public string GetRandomPrompt()
    {
        // random index thing
        string filepath = @"C:\Users\Cortex\Documents\cdporje\cse210-hw\Mindfulness\ReflectionManager.md";
        string[] lines = File.ReadAllLines(filepath);
        Random random = new Random();
        int randindex = random.Next(19, 24);

        return lines[randindex];
    }
    
    public void Run()
    {
        // runs the activity
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write($"You may begin in: ");
        for(int i=5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        DateTime currentTime = DateTime.Now;

        int cn = 0;
        Console.WriteLine("");
        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("> ");
            Console.ReadLine();
            cn++;
        }
        Console.WriteLine($"You listed {cn} items!");
    }

}