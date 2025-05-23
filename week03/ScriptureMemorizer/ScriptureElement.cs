using System;

public class ScriptureElement
{
    //Attributes
    private int _numberOfScripture;
    private string _textReference;
    private string _textScripture;

    //Constructor
    public ScriptureElement()
    {
    }

    public ScriptureElement(int numberOfScripture, string textReference, string textScripture)
    {
        _numberOfScripture = numberOfScripture;
        _textReference = textReference;
        _textScripture = textScripture;
    }
    
    public int GetNumberOfScripture()
    {
        return _numberOfScripture;
    }

    public void SetNumberOfScripture(int numberOfScripture)
    {
        _numberOfScripture = numberOfScripture;
    }

    public string GetTextReference()
    {
        return _textReference;
    }

    public void SetTextReference(string textReference)
    {
        _textReference = textReference;
    }

    public string GetTextScripture()
    {
        return _textScripture;
    }

    public void SetTextScripture(string textScripture)
    {
        _textScripture = textScripture;
    }

    //Methods
    public void DisplayScriptureElement()
    {
        Console.WriteLine($"{_numberOfScripture}) {_textReference}");
        Console.WriteLine($"{_textScripture}");
    }
}
