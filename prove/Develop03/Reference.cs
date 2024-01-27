public class Reference
{
    private string _book = "";
    private int _chapter = 0;
    private int _verse = 0;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Second constructor, if the scripture do not hace endVerse

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetDisplayText() {
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }

//book
   public void SetBook(string book) {
        _book = book;
    }

    public string GetBook()
    {
        return _book;
    }

    //chapter
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public int SetChapter()
    {
        return _chapter;
    }
    //verse
    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public int GetVerse()
    {
        return _verse;
    }

    //endVerse

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }


}