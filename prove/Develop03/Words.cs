using System;
public class Words
{
    private string _word;//it will recognize the words are still there
    private bool _hidden; //this bool at the ebginning should be false, meaning that the word is still there

    public Words(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {

    }
}

//split?