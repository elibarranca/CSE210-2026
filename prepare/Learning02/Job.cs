using System;

public class Job
{
    //Create member variables for company, job title, start year, end year
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    // Now I display the job information, void returns nothing, i give it no parameters so it will use the data it already has
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}