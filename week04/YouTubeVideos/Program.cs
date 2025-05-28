using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        //List for videos
        List<Video> listVideo = new List<Video>();
        //Dictionary of videos
        Dictionary<int, Video> videosPorId = new Dictionary<int, Video>();
        videosPorId.Add(1, new Video("Part 1 - C# Tutorial - Introduction.avi", "Venkat", 789));
        videosPorId.Add(2, new Video("Part 2 - C# Tutorial - Reading and writing to a console.avi", "Venkat", 672));
        videosPorId.Add(3, new Video("Part 3 - C# Tutorial - Built - in types.avi", "Venkat", 621));
        //Dictionary of comments
        Dictionary<int, Comment> commentsPorId = new Dictionary<int, Comment>();
        commentsPorId.Add(11, new Comment("@VinayYadav-yo5hu", "First time in my life i got addict of study, it's because of your videos."));
        commentsPorId.Add(12, new Comment("@KimaniWaNdirangu", "I have watched this C# video tutorials over and over again.I'm now a competent and confident C# developer. Thank you Venkat. Be blessed."));
        commentsPorId.Add(13, new Comment("@exogendesign4582", "This is a Real Teacher. Not just someone who just damn the code without explaining it."));
        commentsPorId.Add(21, new Comment("@DerperDaDerpa", "Wow good stuff I have a feeling this tutorial series is a great find, thank you for these!"));
        commentsPorId.Add(22, new Comment("@krismaly6300", "I enjoy watching this video and recommend others."));
        commentsPorId.Add(23, new Comment("@kanasree123", "Your Presentation and explanation is Awesum Sir!! Became a Big Fan of you..!!"));
        commentsPorId.Add(31, new Comment("@svensekmirko", "Not all superheros wear capes! You sir are a legend!"));
        commentsPorId.Add(32, new Comment("@piyasidey2117", "Happy Teachers Day..You are the best teacher.."));
        commentsPorId.Add(33, new Comment("@Naniloobaby", "Very good content after a decade I'm learning this."));
        // List of videos
        foreach (var video in videosPorId)
        {
            Video vid = videosPorId[video.Key];
            //List of comments
            foreach (var com in commentsPorId)
            {
                if (video.Key.ToString() == com.Key.ToString().Substring(0, 1))
                {
                    Comment comment = commentsPorId[com.Key];
                    vid.AddComment(comment);
                }
            }
            listVideo.Add(vid);
        }
        //Display video information
        Console.WriteLine("Welcome to the YouTube Video Program.\n");
        foreach (Video video in listVideo)
        {
            Video vid = video;
            vid.DisplayVideoInformation(video);
        }

    }
}