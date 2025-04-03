class Specialist: Staff
{
    private string _specialty;

    public Specialist(string fname, string lname, string gender, string specialty):base(fname, lname, gender)
    {
        _specialty = specialty;
        Greeting(_lname, _gender);
        Console.WriteLine($" I am a {_specialty} specialist.");
    }
    
    
   /* public void Greeting()
   {
        string title = "";
        if(_gender == "Male")
        {
            title = "Mr.";
        }
        else if(_gender == "Female")
        {
            title = "Ms.";
        }
        Console.WriteLine($"Hello students, I am {title} {_lname}. I am a {_specialty} specialist."); 
        Console.WriteLine();
   } */ 

}