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
        // DONE TODO: Increment breathe time with iterations
        int cn = 0; // this is to make sure that the faster iteration runs at least once
        // so I set it up in this weird way so that both iteration of a fast and slow version would always work, where it would always start and end with the fast one
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
    }
}