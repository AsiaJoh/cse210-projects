class Lecture : Event
{
    string _speaker;
    string _maxCapacity;

    // Constructor(s)
    public Lecture(string eventType) : base(eventType) 
    {

    }

    // Method(s)

    // Getter(s)/Setter(s)
    public string GetSpeaker()
    {
        return _speaker;
    }
    public string GetMaxCapacity()
    {
        return _maxCapacity;
    }



    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public void SetMaxCapacity(string maxCapacity)
    {
        _maxCapacity = maxCapacity;
    }
}