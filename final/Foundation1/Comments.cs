class Comments
{
    private string _name = "Anon";
    private string _text = "This is a placeholder text";

    public Comments(string n, string t)
    {
        _name = n;
        _text = t;
    }


    public void Display()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_text);
    }


}