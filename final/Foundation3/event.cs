class Event {
    string _eventTitle;
    string _description;
    string _date;
    string _time;
    Address _address;
    string _eventType;

    // Constructor(s)
    public Event(string eventType) {
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
    public string standardDetails(string eventTitle, string description, string date, string time, Address address) {

    }

    public string shortDescription(string eventTitle, string date) {

    }

    public string fullDetails() {
        // If statement determines what string is returned, based on the event type, which is known upon conception of the event

    }

    // Getter(s)/Setter(s)
    public string GetEventTitle() {
        return _eventTitle;
    }
    public string GetDescription() {
        return _description;
    }
    public string GetDate() {
        return _date;
    }
    public string GetTime() {
        return _time;
    }
    public Address GetAddress() {
        return _address;
    }
    public string GetEventType() {
        return _eventType;
    }


    public void SetEventTitle(string eventTitle) {
        _eventTitle = eventTitle;
    }
    public void SetDescription(string description) {
        _description = description;
    }
    public void SetDate(string date) {
        _date = date;
    }
    public void SetTime(string time) {
        _time = time;
    }
    public void SetAddress(Address address) {
        _address = address;
    }
    public void SetEventType(string eventType) {
        _eventType = eventType;
    }
}