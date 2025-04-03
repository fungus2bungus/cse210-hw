
using System.Linq.Expressions;

public class Entry
{
    public string _author;
    public string _date = DateTime.Now.ToString("dd/MM/yyyy");
    public string _prompt;
    public string _response;

    public Entry(string author, string prompt)
    {
        _author = author;
        _prompt = prompt;
    }
    
    public void UserInput()
    {
        _response = Console.ReadLine();
    }
    
    private void DisplayDate()
    {
        DateTime currentDate = DateTime.Now;
        // Console.Write(currentDate.ToString("dd-MM-yyyy"));
        _date = currentDate.ToString("dd-MM-yyyy");
        // return currentDate.ToString("dd-MM-yyyy");
    }

    public string Display()
    {
        // Console.WriteLine($"Author: {_author} Date: {_date} Prompt: {_prompt}");
        // Console.WriteLine($"Date: {_date}");
        // Console.WriteLine("");
        // DisplayDate();
        // Console.WriteLine(_prompt);
        // Console.WriteLine("");
        // Console.WriteLine($"Response: {_response}");
        return $"Author: {_author} - Date: {_date} - Prompt: {_prompt}";

    }
}