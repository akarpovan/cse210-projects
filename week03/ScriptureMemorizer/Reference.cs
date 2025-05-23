using System;

public class Reference
{
    //Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    //Constructor
    public Reference()
    {
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    //Constructor
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    //Methods
    public string GetDisplayText()
    {
        string text = "";
        if (_endVerse.HasValue) 
        {
            text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            text = $"{_book} {_chapter}:{_verse}";
        }
        return text;
    }

    public Reference GetReference(string textReference)
    {
        Reference reference = new Reference();

        // Find the index of the first digit (start of chapter)
        int firstDigitIndex = -1;
        for (int i = 0; i < textReference.Length; i++)
        {
            if (char.IsDigit(textReference[i]))
            {
                firstDigitIndex = i;
                break;
            }
        }

        // Extract book name (everything before chapter number)
        string book = textReference.Substring(0, firstDigitIndex).Trim();

        // Extract chapter and verse part
        string chapterAndVerses = textReference.Substring(firstDigitIndex).Trim();

        // Split chapter and verses by ':'
        string[] parts = chapterAndVerses.Split(':');
        int chapter = int.Parse(parts[0]);

        // Split verses by '-' to get verse and optional endVerse
        string[] verses = parts[1].Split('-');
        int verse = int.Parse(verses[0]);
        int? endVerse = verses.Count() > 1 ? int.Parse(verses[1]) : null;

        reference._book = book;
        reference._chapter = chapter;
        reference._verse = verse;
        reference._endVerse = endVerse;
        
        return reference;
    }
}
