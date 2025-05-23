using System;
using System.IO;

public class Scripture
{
    //Attributes
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();
    private Random _random;

    private int _numberOfScripture;
    private string _textScripture;
    private string _textReference;

    //Constructor
    public Scripture()
    {
    }

    public Scripture(int numberOfScripture, Reference reference, string text)
    {
        _numberOfScripture = numberOfScripture;
        _reference = reference;
        _textScripture = text;
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        // Split text into words
        var splitWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in splitWords)
        {
            Word textWord = new Word(word);
            _words.Add(textWord);
        }
    }

    //Methods
    public void AddWord(Word word)
    {
        _words.Add(word);
    }

    public string GetTextScripture()
    {
        return _textScripture;
    }

    public void SetTextScripture(string textScripture)
    {
        _textScripture = textScripture;
    }

    public string GetTextReference()
    {
        return _textReference;
    }

    public void SetTextSReference(string textReference)
    {
        _textReference = textReference;
    }

    public int GetNumberOfScripture()
    {
        return _numberOfScripture;
    }

    public void SetNumberOfScripture(int numberOfScripture)
    {
        _numberOfScripture = numberOfScripture;
    }

    public void HideRandomWords(int count = 5)
    {
        if (_words.Count == 0)
            return;

        int index = 0;
        for (int i = 0; i < count; i++)
        {
            index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public void HideRandomUnhiddenWords(int count = 5)
    {
        if (_words.Count == 0)
            return;
            
        List<Word> _unhiddenWords = new List<Word>();
        foreach (var word in _words)
        {
            if (!word.GetIsHidden())
            {
                _unhiddenWords.Add(word); // Found a word that is not hidden
            }
        }
        if (_unhiddenWords.Count == 0)
            return;

        int toHide = Math.Min(count, _unhiddenWords.Count);
        for (int i = 0; i < toHide; i++)
        {
            int index = _random.Next(_unhiddenWords.Count);
            _unhiddenWords[index].Hide();
            _unhiddenWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";

        for (int i = 0; i < _words.Count; i++)
        {
            displayText += _words[i].GetDisplayText();
            if (i < _words.Count - 1)
            {
                displayText += " ";
            }
        }
        return displayText;
    }


    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false; // Found a word that is not hidden
            }
        }
        return true; // All words are hidden
    }

    public List<ScriptureElement> _elements = new List<ScriptureElement>();

    public void AddElement(ScriptureElement scriptureElement)
    {
        _elements.Add(scriptureElement);
    }

    public List<ScriptureElement> LoadFromFile()
    {
        Console.Write("Enter filename to load scriptures: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
        }

        try
        {
            List<ScriptureElement> loadedScriptureElements = new List<ScriptureElement>();
            foreach (var line in File.ReadAllLines(filename))
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    ScriptureElement element = new ScriptureElement(Convert.ToInt32(parts[0]), parts[1], parts[2]);
                    if (element != null)
                        loadedScriptureElements.Add(element);
                }
            }
            _elements = loadedScriptureElements;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}\n");
        }
        return _elements;
    }

    public void DisplayElements()
    {
        if (_elements.Count == 0)
        {
            Console.WriteLine("No elements to display.\n");
            return;
        }

        foreach (ScriptureElement element in _elements)
        {
            element.DisplayScriptureElement();
        }
    }

}
