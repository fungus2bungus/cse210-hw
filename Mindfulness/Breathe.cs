class Breathe : Activity
{
    public Breathe()
    {
        _startingmsg = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _name = "Breathing";
    }
    public void Run()
    {
        // runs breathe activity
        // so it needs to do something with _time, update the console in real-time
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        DateTime currentTime = DateTime.Now;


        Console.WriteLine("");
        // okay, this all works, but now I need to somehow have the loops increase in time...
        // TODO: Increment breathe time with iterations
        // int k = 2;
        // int g = 3;
        int cn = 0;
        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            if(cn == 0 || currentTime > futureTime.AddSeconds(-10))
            {
                Console.WriteLine("");
                Console.Write("Breathe in...");

                for(int i = 2; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("");
                Console.Write("Breathe out...");
                for(int i = 3; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                currentTime = DateTime.Now;
            }

            else
            {
                Console.WriteLine("");
                Console.Write("Breathe in...");
                for(int i=4; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                
                Console.WriteLine("");
                
                Console.Write("Breathe out...");

                for(int i=6; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                currentTime = DateTime.Now;
            }
            Console.WriteLine("");
            cn++;
        }
        
        // Thread.Sleep(_time*500);
    }
    
    private string filepath = @"C:\Users\Cortex\Documents\cdporje\cse210-hw\Mindfulness\ReflectionManager.md";

    private List<string> _prompt = new List<string>(File.ReadAllLines(@"C:\Users\Cortex\Documents\cdporje\cse210-hw\Mindfulness\ReflectionManager.md"));
    
    // tried to be fancy, kinda unecessary
    public void DisplayStart()
    {
        int[] lined = {27, 28, 29, 30};
        // List<int> lined = new List<int>(29, );
        foreach(int i in lined)
        {
            if (i >= 0 && i < _prompt.Count())
            {
                Console.WriteLine($"{_prompt[i]}");
            }
        }
        Console.Write($"{_prompt[31]}");
    }
    

    

}