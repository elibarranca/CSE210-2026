using System;

class Goal
{
    public string _name = "";
    public string _description = "";
    public int _points = 0;
    public virtual void RecordEvent()
    {
    }
    public virtual string GetStatus()
    {
        return "[ ]" + _name;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
}