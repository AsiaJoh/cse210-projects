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
        Comment epicComment1 = new Comment();
        epicComment1.SetName("hooligan");
        epicComment1.SetText("Oh no!!!");

        Comment epicComment2 = new Comment();
        epicComment2.SetName("Skateboarder2000");
        epicComment2.SetText("Lol");

        Comment epicComment3 = new Comment();
        epicComment3.SetName("E");
        epicComment3.SetText("Imagine throwing yourself at the floor and missing.");

        Comment epicComment4 = new Comment();
        epicComment4.SetName("Professor Higgens");
        epicComment4.SetText("Spoonfull of sugar helps the medicine go down");

        // Append Video 2 to Video list
        videoList.Add(epicFailsVideo);
        // Append comments to Video 2's Comment list
        epicFailsVideo.AppendComment(epicComment1);
        epicFailsVideo.AppendComment(epicComment2);
        epicFailsVideo.AppendComment(epicComment3);
        epicFailsVideo.AppendComment(epicComment4);


        // Video 3
        Video hampterVideo = new Video();
        hampterVideo.SetAuthor("pneumonoultramicroscopicsilicovolcanoconiosis");
        hampterVideo.SetLength(1);
        hampterVideo.SetTitle("hampter");

        // Video 3's comments
        Comment hampterComment1 = new Comment();
        hampterComment1.SetName("Asdf");
        hampterComment1.SetText("he spin");

        Comment hampterComment2 = new Comment();
        hampterComment2.SetName("Eo");
        hampterComment2.SetText("Look at him go");

        Comment hampterComment3 = new Comment();
        hampterComment3.SetName("Nonsensicalll");
        hampterComment3.SetText("Majestic");

        // Append Video 3 to Video list
        videoList.Add(hampterVideo);
        // Append comments to Video 3's Comment list
        hampterVideo.AppendComment(hampterComment1);
        hampterVideo.AppendComment(hampterComment2);
        hampterVideo.AppendComment(hampterComment3);


        // Then, have your program iterate through the list of videos 
        foreach (Video video in videoList) { 
            // and for each one, display the title, author, length, number of comments (from the method) 
            Console.WriteLine("----------");
            video.DisplayVideo();

            // and then list out all of the comments for that video. 
            video.DisplayCommentsList();
        }
    }
}