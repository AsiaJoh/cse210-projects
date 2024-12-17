class OutGathering : Event
{
    string _weather;

    // Constructor(s)
    public OutGathering(string eventType) : base(eventType) 
    {

    }

    // Method(s)

    // Getter(s)/Setter(s)
    public string GetWeather()
    {
        return _weather;
    }



    public void SetWeather(string weather)
    {
        _weather = weather;
    }
}