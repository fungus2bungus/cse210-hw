class Program
{
    static void MenuDisplay()
    {
        Console.WriteLine($"Menu Display");
        Console.WriteLine($"  1. Start breathing activity");
        Console.WriteLine($"  2. Start relfecting activity");
        Console.WriteLine($"  3. Start listing activity");
        Console.WriteLine($"  4. Quit");
        Console.Write($"Select a choice from the menu: ");
    }
    // DONE TODO: starts with the menu display
    // DONE TODO: declare class objects
    // breathe, listing, reflect

    static void Main()
    {
        string m = "";
        
        while (m != "4")
        {
            switch(m)
            {
                case "1":
                // DONE TODO: do Breathing activity
                Breathe breathe1 = new Breathe();
                breathe1.ShowIntro();
                breathe1.GetTimer();
                breathe1.ShowCountdown();
                breathe1.Run();
                breathe1.ShowEnding();
                break;

                case "2":
                // DONE TODO: do relfecting activity
                Reflect reflect1 = new Reflect();
                reflect1.ShowIntro();
                reflect1.GetTimer();
                reflect1.ShowCountdown();
                reflect1.Run();
                reflect1.ShowEnding();
                break;

                case "3":
                // DONE TODO: do listing activity
                Listing listing1 = new Listing();
                listing1.ShowIntro();
                listing1.GetTimer();
                listing1.ShowCountdown();
                listing1.Run();
                listing1.ShowEnding();
                break;

                case "4":
                // not really sure what this would do...
                break;

                default:
                Console.WriteLine("Improper input. Choose from shown options");
                // do nothing
                break;


            }
            MenuDisplay();
            m = Console.ReadLine();

        }
        // while loop to run one
/*         Listing test1 = new Listing();

        for(int i = 0; i < 4; i++)
        {
            Console.WriteLine(test1.GetRandomPrompt());
        } */
    // this here was kinda just to test the prompt generators 
    }
}