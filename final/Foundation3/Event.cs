using System.ComponentModel;
using System.Net.Sockets;

class Event
{
    public string _title = "";
    public string _description = "";
    public string _date = "";
    public string _time = "";
    public Address _address = new Address();


    public string GetStandardDetails()
    {
        return _title + "\n" + _description + "\n" + _date + "\n" + _time + "\n" + _address.GetFullAddress();
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();

    }
    public string GetShortDescription()
    {
        return _title + "\n" + _date;
    }

}