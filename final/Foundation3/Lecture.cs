class Lecture : Event
{
    public string _speakerName = "";
    public int _capacity = 0;
    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + "\nType: Lecture" + "\nSpeaker: " + _speakerName + "\nCapacity: " + _capacity;
    }
}