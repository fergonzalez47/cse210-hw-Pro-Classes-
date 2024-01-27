using System;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string text, Reference reference)
    {

        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word objWord = new Word(word);
            _words.Add(objWord);
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string text = "";
        foreach (var word in _words)
        {
            text += $" {word.GetDisplayText()}";
        }
        return $"{reference} {text}";
    }

    public void HideRandomWords()
    {
        Random randomGenerator = new Random();

        for (int i = 0; i < 3;)
        {

            int index = randomGenerator.Next(0, _words.Count);

            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                i++;
            }
            if (IsCompletelyHidden() == true)
            {
                break;
            }
        }

    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}