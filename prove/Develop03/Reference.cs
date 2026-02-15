using System;

public class Reference //parts of the scripture reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    //CONSTRUCTORS!!
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = endVerse;
    }
    public Reference(string book, int chapter, int verse, endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = endVerse;
    }
    public string GetText()//This should get the reference
    {
        string result = _book + " " _chapter + ":" + _verse;
        if (_endVerse > 0)
        {
            result = result + " " + _endVerse;
        }
        return result;//show what is left
    }
}