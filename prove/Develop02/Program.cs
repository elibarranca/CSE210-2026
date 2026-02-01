using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Serialization;

//My program must call Prompt when writing , Entry when displaying and File logic when saving/loading
//Program should : 
//Show the menu
//Read the number the user types
//Decide what happens next 
//Store the list of entry objects

public class Program
{
    public static void Main(string[] args) //this is main
    {
        List<Entry> entries = new List<Entry>(); //I need a list of the options in the menu

        int choice = 0; //the user will choose and the program finishes when they Quit
        while (choice != 5)
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to your Journal! ");
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices ");
            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("");

            string input = Console.ReadLine(); //I need the person to input a choice
            choice = int.Parse(input);

            if (choice == 1)// to write
            {   //I need the user to input an aswer after it is given a prompt, there needs to eb a date, and then it weill need to be saved
                Prompts promptGen = new Prompts();
                string prompt = promptGen.GetRandomPrompt();

                Console.WriteLine("Please answer to these prompts");
                Console.WriteLine($"Prompt: {prompt}");

                string answer = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry.prompt = prompt;
                newEntry.response = answer;

                entries.Add(newEntry);
            }
            else if (choice == 2)//to display
            {

            }
            else if (choice == 3) //to load
            {

            }
            else if (choice == 4) //to save
            {
                Console.Write("What is the filename? ");

                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in entries)
                    {
                        outputFile.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}");
                    }
                }
            }
            else if (choice == 5) //to quit
            {
                Console.WriteLine("Goodbye!");
            }
            else //what if they did not read the question and do something else?
            {
                Console.WriteLine("Ooops! That is not an option.\n");
            }
        }

    }
}







