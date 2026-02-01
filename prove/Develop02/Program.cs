using System;
using System.Collections.Generic;
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
        }

    }
}







//Console.Write("What is the filename? ");

//string filename = Console.ReadLine();

//using (StreamWriter outputFile = new StreamWriter(filename))
//{
//   foreach (Entry entry in entries)
//    {
//       outputFile.WriteLine();
//    }
//}