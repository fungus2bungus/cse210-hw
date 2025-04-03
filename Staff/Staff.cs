class Staff
{
   protected string _fname;
   protected string _lname;
   protected string _gender;

   public Staff(string fname, string lname, string gender)
   {
      _fname = fname;
      _lname = lname;
      _gender = gender;
   }
   
   // can also make a function here to get the the title of person to be displayed
   // like protected string GetDisplayTitle()
   // 
   // SetName()

   public void SetName(string first, string last)
   {
      _fname = first;
      _lname = last;
   }
   
   public void DisplayName()
   {
      Console.WriteLine($"{_fname} {_lname}");
   }
   
   public void Greeting(string last, string gender)
   {
        string title = "";
        if(gender == "Male")
        {
            title = "Mr.";
        }
        else if(gender == "Female")
        {
            title = "Ms.";
        }
        Console.Write($"Hello students, I am {title} {last}.");
   } 
}