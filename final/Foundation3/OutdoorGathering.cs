class OutdoorGathering : Event
{
    public string _weatherForecast = "";

    public override string GetFullDetails()
    {
        return GetStandardDetails() + "\nType: Outdoor Gathering" + "\nWeather: " + _weatherForecast;
    }
}