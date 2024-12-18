abstract class Activity
{
    string _date;
    int _timeLength;
    string _activityType;
    string _time;
    float _rate;

    // Constructor(s) will only be used by derived classes because this class is abstract
    public Activity()
    {

    }

    // Method(s)
    public abstract float CalcDistance();

    public abstract float CalcSpeed();

    public abstract float CalcPace();

    public string Summary(float distance, float speed) 
    {

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