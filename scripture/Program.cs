using System;

// So it pretty much works, I just can't get it to check for if something is hidden or not correctly, don't know if that's something I can fix
public class Program
{
    static void Main()
    {
        // DONE TODO set up a referrence object
        Reference refn = new Reference("Psalms", 3, 3, 5);
        // DONE TODO declare the associated scripture
        Scripture script = new Scripture(refn, "Let not mercy and truth forsake thee: bind them about thy neck; write them upon the table of thine heart: So shalt thou find favour and good understanding in the sight of God and man. Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        // spacing for the output and declares the string variable for the 'quit' text
        Console.WriteLine("");
        string progRun = "";

        // While loop that runs until s="quit"
        while(progRun != "quit")
        {
            // Writes instruction input, assigns s to input
            Console.WriteLine($"Press enter to continue or type 'quit' to finish: ");
            progRun = Console.ReadLine();

            // TODO: make this do something, I don't remember why its here?
            // Stops Hide() function from running?
            if(script.AllHidden() == false)
            {
                script.HideRandomWords();
                Console.Clear();
                refn.Display();

            }
            else
            {
                break;
            }
                script.GetDisplayContent();
                Console.WriteLine("");
                Console.WriteLine("");         
            // script.HideRandomWords();
            // Console.Clear();

            // Displays the content, or rather re-displays the Reference along with the updated scripture
            

            // For proper spacing
            
        }

    }
}