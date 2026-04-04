class Address
{

    public string _street = " ";
    public string _city = " ";
    public string _state = " ";
    public string _country = " ";

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetFullAddress()
    {
        return _street + "\n" + _city + ", " + _state + "\n" + _country;
    }

}