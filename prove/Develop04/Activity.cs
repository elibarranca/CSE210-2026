using System;
using System.ComponentModel;
//All activityies share:
//name
//description
//duration
//start message
//end message
//spinner animation

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void WelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} <3");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long (in seconds) would you like the activity to last?");
        string iput = Console.ReadLine();
        _duration = int.Parse(input);

        Console.Clear();
        Console.WriteLine("Gret ready...");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    [



    ]

}
