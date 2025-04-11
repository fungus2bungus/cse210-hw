using System;

class Program
{
    static void Main(string[] args)
    {
        Address add1 = new Address("1234 mine drive", "Sugar", "Idaho", "USA");
        Customer cust1 = new Customer("James", add1);
        Product prod1 = new Product("Broom", 0034, 10, 2);
        Product prod2 = new Product("Paper Towel", 0044, 4, 6);
        Order order1 = new Order(cust1);

        order1.AddProduct(prod1);
        order1.AddProduct(prod2);
        
        Address add2 = new Address("2874 West South Way", "Leeds", "England", "UK");
        Customer cust2 = new Customer("Harold", add2);
        Order order2 = new Order(cust2);
        Product prod3 = new Product("Fridge Magnets", 204, 5, 4);
        Product prod4 = new Product("Basketball", 1040, 20, 1);
        Product prod5 = new Product("Tennis Ball", 1036, 6, 3);
        
        order2.AddProduct(prod3);
        order2.AddProduct(prod4);
        order2.AddProduct(prod5);


        // order1.PackingLable();
        // order1.ShippingLable();
        
        order1.DisplayAll();
        
        order2.DisplayAll();
        
    }
}