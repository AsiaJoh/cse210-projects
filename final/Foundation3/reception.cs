class Reception : Event
{
    bool _rsvp;
    bool _registriation;

    // Constructor(s)
    public Reception(string eventType) : base(eventType) 
    {

    }

    // Method(s)

    // Getter(s)/Setter(s)
    public bool GetRSVP()
    {
        return _rsvp;
    }
    public bool GetRegistration()
    {
        return _registriation;
    }



    public void SetRSVP(bool rsvp)
    {
        _rsvp = rsvp;
    }
    public void SetRegistration(bool registration)
    {
        _registriation = registration;
    }
}