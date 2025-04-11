public class Book
{
    private string _title;
    private string _author;
    private string _checkOutDate;

    public Book(string newTitle, string newAuthor)
    {
        
        _title=newTitle;
        _author=newAuthor;
        _checkOutDate="";
    }
    
    public void CheckOut()
    {
        
    }
    
    public bool IsCheckedOut()
    {
       return true; 
    }
    
    public void Display()
    {
        
    }
}