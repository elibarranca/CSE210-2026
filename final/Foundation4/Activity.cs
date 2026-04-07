class Activity
{
    public string _date = "";
    public int _minutes = 0;

    public virtual float GetDistance()
    {
        return 0;
    }
    public virtual float GetSpeed()
    {
        return 0;
    }
    public virtual float GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return _date + " " + _minutes + "min - Distance: " + GetDistance() + "miles, Speed: " + GetSpeed() + " mph, Pace: " + GetPace() + "min per mile";
    }
}