class Activity
{
    // declare objects
    protected string _startingmsg = "start";
    protected string _name = "default";
    protected int _time = 0;

    public Activity()
    {
        
    }
    
    // does stuff
    
    public void ShowSpinner()
    {
        // does annimation for the throbber
        // maybe only work on this once everything else is done
        for(int i = 0; i < 2; i++)
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        
    }
    
    // DONE TODO: ShowIntro() I might need some paramaters for this...
    // string name as activity name, then string description,
    public void ShowIntro()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine("");
        Console.WriteLine($"{_startingmsg}");
        Console.WriteLine($"");
        Console.Write($"How long, in seconds, would you like this session? ");
        
    }
    
    public void GetTimer()
    {
        string dsd = Console.ReadLine();
        _time = int.Parse(dsd);
    }
    
    public void ShowCountdown()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();

    }
    
    public void ShowEnding()
    {
        Console.WriteLine("Well Done!!");
        ShowSpinner();
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_time} seconds of the Breathing Activity.");
        ShowSpinner();
    }
}