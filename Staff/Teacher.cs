class Teacher: Staff
{
   private int _room_num;

   public Teacher(string fname, string lname, string gender, int room_num):base(fname, lname, gender)
   {
       _room_num = room_num;
       Greeting(_lname, _gender);
       Console.WriteLine($" I teach in room {_room_num}.");
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
            title = "Mrs.";
        }
        Console.WriteLine($"Hello students, I am {title} {_lname}. I teach in room {_room_num}");
        Console.WriteLine();
   } */ 

}