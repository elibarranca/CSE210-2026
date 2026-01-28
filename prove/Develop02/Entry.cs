using System;
using System.IO; 


// 1. Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
// 3. Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.

class Entry
{
    static void Main(string[] args)
    {
        string filename = "entryFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("Welcome to your personal Journal.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");


        }
    }

    
}