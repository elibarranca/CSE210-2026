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
        List<Goal> goals = new List<Goal>();
        int totalScore = 0;

        bool running = true;
        while (running)
        {
            Console.WriteLine("Your score: " + totalScore);
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Quit");
            Console.Write("Choose and option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("What kind of goal?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                string goalType = Console.ReadLine();

                Goal newGoal;

                if (goalType == "1")
                {
                    newGoal = new SimpleGoal();
                }
                else if (goalType == "2")
                {
                    newGoal = new EternalGoal();
                }
                else
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    Console.Write("How many times to complete? ");
                    checklistGoal._targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Bonus points: ");
                    checklistGoal._bonusPoints = int.Parse(Console.ReadLine());
                    newGoal = checklistGoal;
                }

                Console.Write("Goal name: ");
                newGoal._name = Console.ReadLine();
                Console.Write("Goal description: ");
                newGoal._description = Console.ReadLine();
                Console.Write("Points for compeltion: ");
                newGoal._points = int.Parse(Console.ReadLine());

                goals.Add(newGoal);
            }
            else if (choice == "2")
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + goals[i]._name);
                }
                Console.Write("Which goal did you complete?");
                int goalIndex = int.Parse(Console.ReadLine()) - 1;
                goals[goalIndex].RecordEvent();
                totalScore += goals[goalIndex]._points;
                Console.WriteLine("You earned " + goals[goalsIndex]._points + " points");
            }
            else if (choice == "3")
            {
                foreach (Goal goal in goals)
                {
                    Console.WriteLine(goal.GetStatus());
                }
            }
            else if (choice == "4")
            {
                running = false;
            }
        }
    }
}