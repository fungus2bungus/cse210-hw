class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public Order(Customer c)
    {
        _customer=c;
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public int GetPriceTotal()
    {
        int ptotal = 0;
        foreach(Product p in _products)
        {ptotal+=p.GetPriceTotal();}
        ptotal+=ShippingCost();
        return ptotal;
    }
    
    public bool IsUSAorder()
    {return _customer.USAresdient();}
    public int ShippingCost()
    {
        if(IsUSAorder() == true)
        {return 5;}
        else
        {return 35;}
    }

    public void PackingLable()
    {
        foreach(Product p in _products)
        {
            p.Display();
        }
    }
    
    public void ShippingLable()
    {
        _customer.Display();
    }

    public void DisplayAll()
    {
        Console.WriteLine("");
        PackingLable();
        ShippingLable();
        Console.WriteLine($"Total Cost: ${GetPriceTotal()}");
    }
}