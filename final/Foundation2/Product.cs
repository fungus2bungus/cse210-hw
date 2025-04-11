class Product
{
    private string _name;
    private int _product_id;
    private int _price;
    private int _quantity;

    public Product(string name, int product_id, int price, int quantity)
    {
        _name=name;
        _product_id=product_id;
        _price=price;
        _quantity=quantity;
    }
    
    public int GetPriceTotal()
    {
        return _price*_quantity;
    }

    public void Display()
    {
        Console.WriteLine($"{_name}, Product_Id: {_product_id}");
    }

}