class ChecklistGoal : Goal
{
    public int _timesCompleted = 0;
    public int _targetCount = 0;
    public int _bonusPoints = 0;

    public override void RecordEvent()
    {
        _timesCompleted++;
    }
    public override string GetStatus()
    {
        if (_timesCompleted >= _targetCount)
        {
            return "[X] " + _name + " Completed " + _timesCompleted + "/" + _targetCount + " times";
        }
        return "[ ]" + _name + " Completed " + _timesCompleted + "/" + _targetCount + " times";
    }

    public override int GetPoints()
    {
        int total = _timesCompleted * _points;
        if (_timesCompleted >= _targetCount)
        {
            total += _bonusPoints;
        }
        return total;
    }
}