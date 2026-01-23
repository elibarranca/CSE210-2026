using System;

class Program
{
    static void Main(string[] args)
    {
        //add new instance for job1
        //set member variables for each element of the job class
        //class, job1, create a Job object
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2022";

        // try this out and then make it a note
        // Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = "2022";
        job2._endYear = "2023";

        // try this out and then make it s note
        // Console.WriteLine(job2._company);

        // try this out:
        // job1.Display();
        //job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Elisa Barranca";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();//everything comes together
    }
}