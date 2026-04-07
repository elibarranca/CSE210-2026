using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address();
        address1._street = "1st W";
        address1._city = "Rexburg";
        address1._state = "Idaho";
        address1._country = "USA";

        Lecture lecture1 = new Lecture();
        lecture1._title = "Why not?";
        lecture1._description = "Why not try something new?";
        lecture1._date = "3/3/2026";
        lecture1._time = "12:30 PM";
        lecture1._address = address1;
        lecture1._speakerName = "Juan Perez";
        lecture1._capacity = 500;

        Reception reception1 = new Reception();
        reception1._title = "When to act?";
        reception1._description = "Learn when is the right time to act";
        reception1._date = "10/3/2026";
        reception1._time = "04:30 PM";
        reception1._address = address1;
        reception1._rsvpEmail = "email@email.com";

        OutdoorGathering outdoor1 = new OutdoorGathering();
        outdoor1._title = "wedding";
        outdoor1._description = "come to the wedding!";
        outdoor1._date = "3/6/2026";
        outdoor1._time = "10:00 AM";
        outdoor1._address = address1;
        outdoor1._weatherForecast = "Sunny and humid";

        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(outdoor1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor1.GetShortDescription());
        Console.WriteLine();

    }
}