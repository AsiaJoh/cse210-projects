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
        lecture.SetDate("10/31/27");
        lecture.SetTime("7:30pm");
        
        // Make a reference to Lecture's address
        Address lectureAddress = lecture.GetAddress();

        // Set up Lecture's address
        lectureAddress.SetStreetAddress("6666 Spooky Drive");
        lectureAddress.SetCity("Scarytown");
        lectureAddress.SetState("Illinois");
        lectureAddress.SetCountry("USA");
        

        // Constructing the Reception Event
        

        // Set Reception's specific variable
        

        // Set Reception's generic variables
        
        
        // Make a reference to Reception's address
        

        // Set up Reception's address
        









        
        // Then, for each event, call each of the methods to generate the marketing messages and output their results to the screen.
    }
}