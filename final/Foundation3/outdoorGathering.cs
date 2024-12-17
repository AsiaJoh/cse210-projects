class OutdoorGathering : Event
{
    string _weather;

    // Constructor(s)
    public OutdoorGathering(string eventType) : base(eventType) 
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