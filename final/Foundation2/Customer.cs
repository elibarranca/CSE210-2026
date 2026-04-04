class Customer
{
    public string _name = "";
    public Address _address = new Address();

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}