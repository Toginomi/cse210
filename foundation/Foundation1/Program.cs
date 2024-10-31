using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Alice", 300);
        video1.AddComment(new Comment("Bob", "Great tutorial!"));
        video1.AddComment(new Comment("Charlie", "Very helpful, thanks."));
        video1.AddComment(new Comment("David", "Looking forward to more videos."));

        Video video2 = new Video("Understanding Abstraction", "Eve", 240);
        video2.AddComment(new Comment("Frank", "This is a complex topic."));
        video2.AddComment(new Comment("Grace", "I love this series."));
        video2.AddComment(new Comment("Hank", "More examples would be nice."));

        Video video3 = new Video("OOP in C#", "Isla", 360);
        video3.AddComment(new Comment("Jack", "I learned a lot from this."));
        video3.AddComment(new Comment("Kira", "Can you explain more on inheritance?"));
        video3.AddComment(new Comment("Leo", "Awesome content!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine(video.GetVideoDetails());
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}