using System;
public class Words
{
    private string _word;//it will recognize the words are still there
    private bool _hidden; //this bool at the ebginning should be false, meaning that the word is still there

    public Words(string word)//Im going to begin hiding the words
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public string GetDisplayText()
    {
        if (_hidden)
        {
            return new string('_', _word.Length);//check if word is there
        }
        else
        {
            return _word;
        }
    }
}
