class EternalGoal : Goal
{
    public int _totalPoints = 0;
    public override void RecordEvent()
    {
        _totalPoints += _points;
    }
    public override string GetStatus()
    {
        return "[ ] " + _name;
    }
    public override int GetPoints()
    {
        return _totalPoints;
    }
}