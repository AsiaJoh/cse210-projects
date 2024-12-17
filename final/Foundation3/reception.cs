class Reception : Event
{
    string _rsvp;

    // Constructor(s)
    public Reception(string eventType) : base(eventType) 
    {

    }

    // Method(s)

    // Getter(s)/Setter(s)
    public string GetRSVP()
    {
        return _rsvp;
    }



    public void SetRSVP(string rsvp)
    {
        _rsvp = rsvp;
    }
    
}