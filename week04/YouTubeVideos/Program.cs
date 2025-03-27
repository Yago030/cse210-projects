using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The hunt", "Marco Antonio", 155);
        Comment comment1 = new Comment("Rafael Perez", "Is bad moovie");
        Comment comment1b = new Comment("Martin  Palermo", "Is best moovie in the world");
        Comment comment1c = new Comment("Rafael Perez", "Is awesome moovie");

        video1.AddComment(comment1);
        video1.AddComment(comment1b);
        video1.AddComment(comment1c);


        Video video2 = new Video("The battle of angels", "Robert De Niro", 2300);
        Comment comment2 = new Comment("Perez Moncho", "Awesome film");
        Comment comment2b = new Comment("Martin  Palermo", "Is best moovie in the world");
        Comment comment2c = new Comment("Rafael Perez", "Is awesome moovie");
        video2.AddComment(comment2);
        video2.AddComment(comment2b);
        video2.AddComment(comment2c);



        Video video3 = new Video("Martin Fierro", "Jose Hernandez", 1670);
        Comment comment3 = new Comment("Martin Carlos", "Is awesome short");
        Comment comment3b = new Comment("Martin Mocho", "Is best resume");
        Comment comment3c = new Comment("Rafael Carlos", "Is bad film");
        video3.AddComment(comment3);
        video3.AddComment(comment3b);
        video3.AddComment(comment3c);

        List<Video> videos = new List<Video> { video1, video2, video3 };



        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}