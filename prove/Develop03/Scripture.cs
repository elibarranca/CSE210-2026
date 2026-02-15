using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Words> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Words>();

        string[] parts = text.Split(" "); //split my scripture into little parts to make the parts list
        for (int i = 0; i < parts.Lenght; i++)
        {
            Words word = new Words(parts[i]); //split in parts
            _words.Add(word);
        }
    }


    //show the scripture
    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetText());
        Console.WriteLine();

        for (int i = 0; i < _words.Count; i++)
        {
            Console.Write(_words[i].GetDisplayText());
            Console.Write(" ");


            Console.WriteLine();
        }
    }
}