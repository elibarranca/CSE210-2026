class Reception : Event
{
    public string _rsvpEmail = "";

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + "\nType: Reception" + "\nRSVP Email: " + _rsvpEmail;
    }
}