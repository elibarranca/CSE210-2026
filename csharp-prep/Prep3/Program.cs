using System;
class Program
{
    static void Main(string[] args)
    {
        //PART 1 wherer I only want to gues the number
        //Console.Write("What is the magic number? "); // Need the answer to be right in the same line

        //string input = Console.ReadLine(); //This input is going to be stored in a variable, and the input is text
        // the input might be numbers so I need to be able to hold that dat
        //int magicNumber = int.Parse(input);  //make it a whole number and convert text to number    AA

        Random randomGenerator = new Random();  //create the random numbers
        int magicNumber = randomGenerator.Next(1, 101); //set limits
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine()); //make it a whole number


            if (guess < magicNumber) //code runs when the numebr is true, but will ask for a lower or higher input
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    } //ends program
}