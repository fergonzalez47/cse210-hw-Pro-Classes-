public class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int seconds)
    {
    _title = title;
    _author = author;
    _seconds = seconds;
    }

    private int GetNumberOfComments() {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        int min = _seconds / 60;
        int seconds = _seconds % 60;

        Console.WriteLine($"- {_title} | Author: {_author} | ");
        Console.WriteLine($"-   Duration:  {min}:{seconds:D2} min");
        Console.WriteLine($"({GetNumberOfComments()}) Comments");
    }
    public void AddComment(Comment text ) {
        _comments.Add(text);
    }

    public List<Comment> GetCommentsList()
    {
        return _comments;
    }

}