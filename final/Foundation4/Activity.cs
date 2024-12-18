public abstract class Activity
{
    string _date;
    // int _timeLength;
    string _activityType;
    float _time;
    float _rate;

    // Constructor(s) will only be used by derived classes because this class is abstract
    public Activity()
    {

    }

    // Method(s)
    public abstract float CalcDistance(float distance);

    public abstract float CalcSpeed(float distance, float time);

    public abstract float CalcPace(float distance, float time);

    public string Summary(float distance, float time) 
    {
        // Produce a string with all the summary information

        // Get information from the methods
        float distanceInfo = CalcDistance(distance);
        float speedInfo = CalcSpeed(distance, time);
        float paceInfo = CalcPace(distance, time);

        string summary = $"Activity Summary: \n{_date} {_activityType} ({time})- Distance {distanceInfo} km, Speed: {speedInfo} kph, Pace: {paceInfo} min per km";

        return summary;
    }

    // Getter(s)/Setter(s)
    public string GetDate()
    {
        return _date;
    }
    public int GetTimeLength()
    {
        return _timeLength;
    }
    public string GetActivityType() 
    {
        return _activityType;
    }
    public string GetTime()
    {
        return _time;
    }
    public float GetRate()
    {
        return _rate;
    }


    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetTimeLength(int timeLength)
    {
        _timeLength = timeLength;
    }
    public void SetActivityType(string activityType) 
    {
         _activityType = activityType;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public void SetRate(float rate)
    {
        _rate = rate;
    }
}