class Volunteer: Staff
{

   public Volunteer(string fname, string lname, string gender) :base(fname, lname, gender)
   {
       Greeting(_lname, _gender);
       Console.WriteLine($" I am a volunteer at the school.");
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
        Console.WriteLine($"Hello students, I am {title} {_lname}. I am a voulunteer at the school."); 
        Console.WriteLine();
   }  */

}