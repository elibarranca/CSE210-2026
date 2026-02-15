using System;

class Program
{           //I need the scripture reference to appear
    static void Main(string[] args) //create the reference
    {//add the scripture
        Reference reference = new Reference("John 3:16");//get the scripture and reference

        string scriptureText = "For God so loved the world that he gave his only begotten Son that whosoever belevieth in him should not perish but have everlasting life";

        Scripture scripture = new Scripture(reference, scriptureText);

        string userInput = "";

        while (userInput != "quit")//close the program
        {

        }
    }
}