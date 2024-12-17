class Lecture : Event
{
    string _speaker;
    int _maxCapacity;

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
    public int GetMaxCapacity()
    {
        return _maxCapacity;
    }



    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public void SetMaxCapacity(int maxCapacity)
    {
        _maxCapacity = maxCapacity;
    }
}