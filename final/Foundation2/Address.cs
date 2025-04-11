class Address
{
    private string _streetAdd;
    private string _city;
    private string _stateProv;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAdd=street;
        _city=city;
        _stateProv=state;
        _country=country;
    }
    
    public bool USAResident()
    {
        //checks if is in united states
        if(_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public string DisplayAddress()
    {
        return _streetAdd+", "+ _city+", "+_stateProv+", "+_country;
        // Console.WriteLine()
    }
}