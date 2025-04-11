using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Test", "Testee", 90);
        v1.AddComments(new Comments("magdsn", "dude, this is freakng epic"));

        v1.DisplayVideo();
    }
}