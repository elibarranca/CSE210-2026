using System;
using System.Threading;
//All activityies share:
//name
//description
//duration
//start message
//end message
//spinner animation

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    //protected means that the clss and the children will see it
    public Activity(string name, string description) //because, constructor! I need a name and description of the activity
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
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    public void EndMessage()
        Console.WriteLine("Good job!!");
        ShowSpinner(4);

    Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds or the {_name}.");
        ShowSpinner(5);


    public void ShowSpinner(int seconds)
    {
        int totalMiliseconds = seconds * 1000;
        int elapsed = 0;

        while (elapsed < totalMiliseconds)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            elapsed = elapsed + 500;

            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            elapsed = elapsed + 500;

            Console.Write("--");
            Thread.Sleep(500);
            Console.Write("\b \b");
            elapsed = elapsed + 500;

            Console.Write("\\");//for some reason this is not letting me have only one
            Thread.Sleep(500);
            Console.Write("\b \b");
            elapsed = elapsed + 500;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i)
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }
}
