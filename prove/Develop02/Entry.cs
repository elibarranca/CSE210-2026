using System;
using System.Collections.Generic;


//For each journal Entry
// it will conatin date, prompt and response 
//It will display on the screen in one line and saved in one line

public class Entry //remember the classes are public
{//everything that goes in the entry
    public string _date;
    public string _prompt;
    public string _response;
    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine();
    }
}