public class Assignment {
    private string _studentName = "";
    private string _topic = "";

    public Assignment()
    {

        _studentName = "Anonymous";
        _topic = "Undefined";
    }
    public Assignment(string studentName, string topic ) {

        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary() {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudentName() {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
}