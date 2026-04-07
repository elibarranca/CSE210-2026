class Cycling : Activity
{
    public float _speed = 0;
    public override float GetDistance()
    {
        return _speed * _minutes / 60;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        return 60 / _speed;
    }
}