class SimpleGoal : Goal
{
    public bool _isComplete = false;
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override string GetStatus()
    {
        if (_isComplete)
        {
            return "[X] " + _name;
        }
        return "[ ] " = _name;
    }
    public override int GetPoints()
    {
        if (_isComplete)
        {
            return _points;
        }
        return 0;
    }
}