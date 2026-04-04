//ABSTRACTION WITH YOUTUBE VIDEOS

using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();

        video1._title = "Lofi music";
        video1._author = "musicguy";
        video1._length = 100;

        video1._comments.Add(new Comment());
        video1._comments[0]._commenterName = "user1";
        video1._comments[0]._commentText = "cool video";

        video1._comments.Add(new Comment());
        video1._comments[1]._commenterName = "user2";
        video1._comments[1]._commentText = "cool music";

        video1._comments.Add(new Comment());
        video1._comments[2]._commenterName = "user3";
        video1._comments[2]._commentText = "good music";

        Video video2 = new Video();

        video2._title = "Movie recap";
        video2._author = "movieguy";
        video2._length = 150;

        video2._comments.Add(new Comment());
        video2._comments[0]._commenterName = "user4";
        video2._comments[0]._commentText = "nice recap";

        video2._comments.Add(new Comment());
        video2._comments[1]._commenterName = "user5";
        video2._comments[1]._commentText = "amazing movie";

        video2._comments.Add(new Comment());
        video2._comments[2]._commenterName = "user6";
        video2._comments[2]._commentText = "make more";

        Video video3 = new Video();

        video3._title = "recipe";
        video3._author = "cookguy";
        video3._length = 90;

        video3._comments.Add(new Comment());
        video3._comments[0]._commenterName = "user7";
        video3._comments[0]._commentText = "yummy dish";

        video3._comments.Add(new Comment());
        video3._comments[1]._commenterName = "user8";
        video3._comments[1]._commentText = "suggest ingredient brands";

        video3._comments.Add(new Comment());
        video3._comments[2]._commenterName = "user9";
        video3._comments[2]._commentText = "great dish";


        Console.WriteLine();

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}