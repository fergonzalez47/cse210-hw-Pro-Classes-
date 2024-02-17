public class Comment {
    private string _personName;
    private string _textComment;

    public Comment(string personName, string textComment) {
        _personName = personName;
        _textComment = textComment;
    }

    public string GetName(){
        return $"{_personName}";
    }
    public string GetComment()
    {
        return $"{_textComment}";
    }

    public void DisplayComment() {
        Console.WriteLine($"  {GetName()}");
        Console.WriteLine($"{GetComment()}");
    }
}