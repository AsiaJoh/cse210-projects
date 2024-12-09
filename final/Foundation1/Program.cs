using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that creates 3-4 videos, setting the appropriate values...
        // and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.
        
        // Initialize the video list
        List<Video> videoList = new List<Video> {};
        
        // Video 1 
        Video lizardVideo = new Video();
        lizardVideo.SetAuthor("LizardFanatic2.0");
        lizardVideo.SetLength(14);
        lizardVideo.SetTitle("Epic Lizard Monatge");

        // Video 1's comments
        Comment lizardComment1 = new Comment();
        lizardComment1.SetName("TriggerHappyMan");
        lizardComment1.SetText("Very epic, lol.");

        Comment lizardComment2 = new Comment();
        lizardComment2.SetName("SadManss");
        lizardComment2.SetText("Aww they're so cute!!");

        Comment lizardComment3 = new Comment();
        lizardComment3.SetName("epiclizard345");
        lizardComment3.SetText("Hey, where'd the Bearded Dragons go?");
        
        // Append Video 1 to Video list
        videoList.Add(lizardVideo);
        // Append comments to Video 1's Comment list
        lizardVideo.AppendComment(lizardComment1);
        lizardVideo.AppendComment(lizardComment2);
        lizardVideo.AppendComment(lizardComment3);
        
        // Video 2
        Video epicFailsVideo = new Video();
        epicFailsVideo.SetAuthor("Skateboard Enthusiast");
        epicFailsVideo.SetLength(5);
        epicFailsVideo.SetTitle("Absolute Epic Fails Montage");

        // Video 2's comments

        // Append Video 2 to Video list

        // Append comments to Video 2's Comment list




        // Video 3

        // Video 3's comments

        // Append Video 3 to Video list

        // Append comments to Video 3's Comment list

































        
        // Then, have your program iterate through the list of videos 
        // and for each one, display the title, author, length, number of comments (from the method) 
        // and then list out all of the comments for that video. 
        // Repeat this display for each video in the list.
    }
}