class Event {
    string _eventTitle;
    string _description;
    string _date;
    string _time;
    Address _address;
    string _eventType;

    // Constructor(s)
    public Event(string eventType) 
    {
        // Assigning the default values, and eventType
        _eventTitle = "Event Title";
        _description = "Event description.";
        _date = "12/16/24";
        _time = "6:00pm";

        // Creating an address belonging to the event
        _address = new Address();
        
        _eventType = eventType;
    }

    // Method(s)
    public string StandardDetails() 
    {
        string address = _address.AddressString();

        string standardDetails = $"{_eventTitle} Event - Standard Details \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress:\n{address}";

        return standardDetails;
    }

    public string FullDetails(string specificInfo1, int specificInfo2 = 0) 
    { // List the same information as standard, plus information specifc to each event
        
        // The two specificInfo's will be transformed into whatever each event needs via if-statement
        // The second parameter is optional/has a default as a int because only the Lecture events require it to exist

        // Initialize specificDetails here so we only do that piece once
        string specificDetails = "";

        // Call this to get the standard info, and then concatenate it with the additional full details later
        string standardInfo = StandardDetails();

        // Use an if statement determines what string is returned, based on the event type, which is known upon conception of the event
        if (_eventType == "Lecture")
        { 
            // Specific Info: speaker name and capacity
            string speaker = specificInfo1;
            int maxCapacity = specificInfo2;

            specificDetails = $"\n\nAdditional Information \nSpeaker Name: {speaker} \nMax Capacity: {maxCapacity}";
        }
        else if (_eventType == "Reception")
        {
            // Specific Info: email for RSVP
            string email = specificInfo1;

            specificDetails = $"\n\nAdditional Information \nEmail for RSVP: {email}";
        }
        else if (_eventType == "OutGathering")
        {
            // Specific Info: weather statement
            string weather = specificInfo1;

            specificDetails = $"\n\nAdditional Information \nPredicted Weather: {weather}";
        }
        else
        {
            specificDetails = "\n\nAdditional specific details could not be given because there was a misspelling, or invalid entry, in the event type.";
        }

        string fullDetails = standardInfo + specificDetails;

        return fullDetails;
    }

    public string ShortDescription() 
    {
        string shortDescription = $"{_eventTitle} Event - Short Description \nEvent Type: {_eventType} \nEvent Date: {_date}";

        return shortDescription;
    }

    // Getter(s)/Setter(s)
    public string GetEventTitle() 
    {
        return _eventTitle;
    }
    public string GetDescription() 
    {
        return _description;
    }
    public string GetDate() 
    {
        return _date;
    }
    public string GetTime() 
    {
        return _time;
    }
    public Address GetAddress() 
    {
        return _address;
    }
    public string GetEventType() 
    {
        return _eventType;
    }



    public void SetEventTitle(string eventTitle) 
    {
        _eventTitle = eventTitle;
    }
    public void SetDescription(string description) 
    {
        _description = description;
    }
    public void SetDate(string date) 
    {
        _date = date;
    }
    public void SetTime(string time) 
    {
        _time = time;
    }
    public void SetAddress(Address address) 
    {
        _address = address;
    }
    public void SetEventType(string eventType) 
    {
        _eventType = eventType;
    }
}