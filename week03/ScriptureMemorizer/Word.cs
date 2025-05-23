using System;

public class Word
{
    //Attributes
    private string _text;
    private bool _isHidden;

    //Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    //Methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }
        else
        {
            string result = "";
            for (int i = 0; i < _text.Length; i++)
            {
                string currentChar = _text.Substring(i, 1);

                if (currentChar != "_")
                {
                    result += "_";
                }
                else
                {
                    result += currentChar;
                }
            }
            return result;
        }
    }
}
