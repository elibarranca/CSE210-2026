using System;
//---1. simple goal can be marked as complete - points stay the same
//---2. eternal goals are never complete - gain more points each time
//---3. provide a checklist goal that must be accomplished a certain numbr of times to be complete (each time the user records a goal they gain value, when they achieve a certain ammount, they get an extra bonus)
//---4. display the users score
//---5. allow the user to create new goals
//---6. allow the user to record if they accomplished the goal
//---7. show a list of the goals (completed/not completed)
//---8. allow the users goals and the current score to be saved and loaded
//-INHERITANCE: Separate class for every kind of activity
//                base class contains shared attributes or behaviors
//-POLYMORPHISM: derived classes override base class methods when needed
//-ENCAPSULATION: private member variables
//-ABSTRACTION: put related items in the same class

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
    }
}