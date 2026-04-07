using System;

class Program
{
    static void Main(string[] args)
    {
        Running running1 = new Running();
        running1._date = "03/03/2026";
        running1._minutes = 30;
        running1._distance = 3;

        Cycling cycling1 = new Cycling();
        cycling1._date = "03/04/2026";
        cycling1._minutes = 45;
        cycling1._speed = 15;

        Swimming swimming1 = new Swimming();
        swimming1._date = "03/05/2026";
        swimming1._minutes = 30;
        swimming1._laps = 20;

        List<Activity> activities = new List<Activity>();
        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swimming1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}