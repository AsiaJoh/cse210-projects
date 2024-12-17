using System;

class Program
{
    static void Main(string[] args)
    {
        // Once you have the classes in place, write a program that creates at least one event of each type and sets all of their values. 
        
        // Constructing the Lecture Event
        Lecture lecture = new Lecture("Lecture");

        // Set Lecture's specific variables
        lecture.SetSpeaker("Edgar Allen Poe");
        lecture.SetMaxCapacity(500);

        // Set Lecture's generic variables
        lecture.SetEventTitle("Edgar Allen Poe - Back From The Dead");
        lecture.SetDescription("Edgar Allen Poe, the famous poet, returns from the dead to speak for us once more. He will deliver a lecture about writing and his most famous poems.");
        lecture.SetDate("10/31/2027");
        lecture.SetTime("7:30pm");
        
        // Make a reference to Lecture's address
        Address lectureAddress = lecture.GetAddress();

        // Set up Lecture's address
        lectureAddress.SetStreetAddress("6666 Spooky Drive");
        lectureAddress.SetCity("Scarytown");
        lectureAddress.SetState("Illinois");
        lectureAddress.SetCountry("USA");
        

        // Constructing the Reception Event
        Reception reception = new Reception("Reception");

        // Set Reception's specific variable
        reception.SetRSVP("anniemail@gmail.com");

        // Set Reception's generic variables
        reception.SetEventTitle("Annie Welcome Reception");
        reception.SetDescription("Come welcome home Annie from her mission! There will be food, treats, and celebrations all around.");
        reception.SetDate("11/15/1995");
        reception.SetTime("5:00pm");
        
        // Make a reference to Reception's address
        Address receptionAddress = reception.GetAddress();

        // Set up Reception's address
        receptionAddress.SetStreetAddress("1234 Little Lane Drive");
        receptionAddress.SetCity("Happyton");
        receptionAddress.SetState("Greater London");
        receptionAddress.SetCountry("UK");


        // Constructing the OutdoorGathering Event
        OutdoorGathering outdoorGathering = new OutdoorGathering("OutdoorGathering");
        
        // Set OutdoorGathering's specific variable
        outdoorGathering.SetWeather("Stormy");

        // Set OutdoorGathering's generic variables
        outdoorGathering.SetEventTitle("Stormyville Neighborhood Party");
        outdoorGathering.SetDescription("Come gather for a neighborhood gathering! There will be new friends, food, games, drinks, even a bouncy house!");
        outdoorGathering.SetDate("06/13/2022");
        outdoorGathering.SetTime("1:00pm");

        // Make a reference to OutdoorGathering's address
        Address outdoorGatheringAddress = outdoorGathering.GetAddress();

        // Set up OutdoorGathering's address
        outdoorGatheringAddress.SetStreetAddress("7890 NW Rainy Lane");
        outdoorGatheringAddress.SetCity("Stormyville");
        outdoorGatheringAddress.SetState("Iowa");
        outdoorGatheringAddress.SetCountry("USA");

        
        // Then, for each event, call each of the methods to generate the marketing messages and output their results to the screen.

        // Lecture Event Marketing
        Console.WriteLine("--------------------");
        Console.WriteLine("Marketing for the latest Lecture Event:");
        Console.WriteLine("--------------------");
        Console.WriteLine();

        lecture.StandardDetails();

        string speaker = lecture.GetSpeaker();
        int maxCapacity = lecture.GetMaxCapacity();
        lecture.FullDetails(speaker, maxCapacity);
        
        lecture.ShortDescription();


        // Reception Event Marketing
        Console.WriteLine("--------------------");
        Console.WriteLine("Marketing for the latest Reception Event:");
        Console.WriteLine("--------------------");
        Console.WriteLine();

        reception.StandardDetails();

        string email = reception.GetRSVP();
        reception.FullDetails(email);
        
        reception.ShortDescription();


        // OutdoorGathering Event Marketing
        Console.WriteLine("--------------------");
        Console.WriteLine("Marketing for the latest Outdoor Gathering Event:");
        Console.WriteLine("--------------------");
        Console.WriteLine();

        outdoorGathering.StandardDetails();

        string weather = outdoorGathering.GetWeather();
        outdoorGathering.FullDetails(weather);
        
        outdoorGathering.ShortDescription();
    }
}