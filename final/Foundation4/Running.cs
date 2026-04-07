class Running : Activity
{
    public float _distance = 0;
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }
    public override float GetPace()
    {
        return _minutes / _distance;
    }
}