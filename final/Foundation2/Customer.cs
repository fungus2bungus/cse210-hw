class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name=name;
        _address=address;
    }
    
    public bool USAresdient()
    {
        return _address.USAResident();
    }
    
    public void Display()
    {
        Console.WriteLine($"Recipient: {_name}, Address: {_address.DisplayAddress()}");
    }
}