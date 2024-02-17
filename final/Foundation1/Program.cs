using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Training Season", "Dua Lipa", 190);
        Video video2 = new Video("Learning React With Next 14", "FernandoG_", 1490);
        Video video3 = new Video("How to design a Navbar using React", "FernandoG_", 1190);

        Comment comment1Video1 = new Comment("Alice Johnson", "Great video! Thanks for sharing.");
        Comment comment2Video1 = new Comment("Bob Smith", "I enjoyed this a lot. Keep up the good work!");
        Comment comment3Video1 = new Comment("Eva Martinez", "Very informative. Learned a lot.");

        video1.AddComment(comment1Video1);
        video1.AddComment(comment2Video1);
        video1.AddComment(comment3Video1);

        Comment comment1Video2 = new Comment("Charlie Brown", "Nice content. Looking forward to more.");
        Comment comment2Video2 = new Comment("Diana Clark", "Could use some improvement, but still interesting.");
        Comment comment3Video2 = new Comment("Frank White", "I have a question about the second point.");

        video2.AddComment(comment1Video2);
        video2.AddComment(comment2Video2);
        video2.AddComment(comment3Video2);

        Comment comment1Video3 = new Comment("Grace Lee", "This is amazing! I'll share it with my friends.");
        Comment comment2Video3 = new Comment("Henry Wang", "I'm not sure I agree with the conclusion.");
        Comment comment3Video3 = new Comment("Isabella Lopez", "Could you elaborate on the third argument?");

        video3.AddComment(comment1Video3);
        video3.AddComment(comment2Video3);
        video3.AddComment(comment3Video3);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        Console.Clear();

        Console.WriteLine("***** Videos *****");

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            
            foreach (Comment comment in video.GetCommentsList())
            {
                comment.DisplayComment();
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }


    }
}