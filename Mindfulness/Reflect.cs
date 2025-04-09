class Reflect : Activity
{
    public Reflect()
    {
        _startingmsg = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _name = "Reflecting";
    }
    private List<string> _prompts = new List<string>();
    public void RunSession()
    {
        // does stuff
        // const objects for menu selection
        // then loops
        // switch statement
        // also might be in a ReflectionManager.cs file
        // why do I have this?
    } 
    
    public void Run() // TODO
    {
        // runs the activity
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt(0)} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        for(int i=5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        DateTime currentTime = DateTime.Now;


        Console.WriteLine("");
        // okay, this all works, but now I need to somehow have the loops increase in time...
        while(currentTime < futureTime)
        {
            Console.WriteLine($"> {GetRandomPrompt(1)} ");
            ShowSpinner();
            ShowSpinner();
            currentTime = DateTime.Now;
            ShowSpinner();
        }
        
    }
    
    // maybe use DateTime
    // DisplayQuestions()

    public string GetRandomPrompt(int n)
    {
        // random index thing
        string filepath = @"C:\Users\Cortex\Documents\cdporje\cse210-hw\Mindfulness\ReflectionManager.md";
        string[] lines = File.ReadAllLines(filepath);
        Random random = new Random();
        int randindex = 0;
        if (n == 0)
        {
            randindex = random.Next(4, 7);
        }
        else if(n == 1)
        {
            randindex = random.Next(8, 17);
        }

        return lines[randindex];
    }
}