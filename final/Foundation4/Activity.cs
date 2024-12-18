public abstract class Activity
{
    string _date;
    // int _timeLength;
    string _activityType;
    float _distance;
    float _time;

    // Constructor(s) will only be used by derived classes because this class is abstract
    public Activity()
    {
        // Create default values
        _date = "17 Dec 2024";
        _activityType = "n/a";
        _distance = 1.0f;
        _time = 1.5f;
    }

    // Method(s)
    public abstract float CalcDistance(float distance);

    public abstract float CalcSpeed(float distance, float time);

    public abstract float CalcPace(float distance, float time);

    public string RetrieveSummary() 
    {
        // Produce a string with all the summary information

        // Get information from the methods
        float distanceInfo = CalcDistance(_distance);
        float speedInfo = CalcSpeed(_distance, _time);
        float paceInfo = CalcPace(_distance, _time);

        string summary = $"Activity Summary: \n{_date} {_activityType} ({_time:F0} min)- Distance {distanceInfo:F1} km, Speed: {speedInfo:F1} kph, Pace: {paceInfo:F2} min per km";

        return summary;
    }

    // Getter(s)/Setter(s)
    public string GetDate()
    {
        return _date;
    }

    public string GetActivityType() 
    {
        return _activityType;
    }
    public float GetDistance()
    {
        return _distance;
    }
    public float GetTime()
    {
        return _time;
    }


    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetActivityType(string activityType) 
    {
         _activityType = activityType;
    }
    public void SetDistance(float distance)
    {
        _distance = distance;
    }
    public void SetTime(float time)
    {
        _time = time;
    }
}