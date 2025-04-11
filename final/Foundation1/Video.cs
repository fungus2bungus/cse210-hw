class Video
{
    private string _title;
    private string _author;
    private int _time;
    private List<Comments> _comments = new List<Comments>();

    public Video(string t, string a, int ti)
    {
        _title = t;
        _author=a;
        _time=ti;
    }
    
    public void DisplayVideo()
    {
        // displays attributes
        Console.WriteLine($"Title: {_title}  Author: {_author}  Duration: {_time}");
        Console.WriteLine("");
        Console.WriteLine($"Comments: {_comments.Count()}");
        Console.WriteLine("");
        foreach(Comments c in _comments)
        {
            c.Display(); 
            Console.WriteLine("");
        }
    }
    
    public void AddComments(Comments co)
    {
        _comments.Add(co);
    }

    // maybe a new comments?
}