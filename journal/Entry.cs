
public class Entry
{
    public string _author;
    public string _date;
    public string _prompt;
    public string _response;
    
    public void UserInput()
    {
        string m = Console.ReadLine();

        while(m != "5")
            {
                if(m == "1")
                {
                    Console.WriteLine($"Write entry selected");
                }
                            
            }

    }

    public void Display()
    {
        Console.WriteLine($"1. Write a new entry");
        Console.WriteLine($"2. Display the journal");
        Console.WriteLine($"3. Save the journal to a file");
        Console.WriteLine($"4. Load journal from file");
        Console.Write($"Select action: ");
    }
}