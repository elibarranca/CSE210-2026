class Swimming : Activity
{
    public int _laps = 0;
    public override float GetDistance()
    {
        return _laps * 50 / 1000 * 0.62f;
    }
    public override float GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
    public override float GetPace()
    {
        return _minutes / GetDistance();
    }
}