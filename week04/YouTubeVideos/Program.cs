using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("Python Basics", "John Smith", 800),
            new Video("Advanced HTML", "Kobe Johnson", 950),
            new Video("C++ Tutorial", "Robert Gales", 1370),
        };

        videos[0].AddComment(new Comment("User369B", "Thanks for your help!"));
        videos[0].AddComment(new Comment("User18A4", "Good video. I'll share with my friends."));
        videos[0].AddComment(new Comment("User46ZZ", "Can you do some more, please?"));
    
        videos[1].AddComment(new Comment("User6F89", "I would like to know more about it."));
        videos[1].AddComment(new Comment("User37N6", "It helped me a lot bro!"));
        videos[1].AddComment(new Comment("UserT267", "New sub! Good job man!"));
   
        videos[2].AddComment(new Comment("User2460", "WOW!"));
        videos[2].AddComment(new Comment("User75H9", "There's no better explanation in the world"));
        videos[2].AddComment(new Comment("User34I6", "Make sense now. Thanks!"));

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
