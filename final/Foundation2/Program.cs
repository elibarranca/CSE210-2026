using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address();
        address1._street = "1st N St";
        address1._city = "Idaho";
        address1._state = "ID";
        address1._country = "USA";

        Customer customer1 = new Customer();
        customer1._name = "Juan Perez";
        customer1._address = address1;

        Product product1 = new Product();
        product1._name = "platano";
        product1._productId = "001";
        product1.price = 3;
        product1.quantity = 5;

        Product product2 = new Product();
        product2._name = "fresa";
        product2._productId = "002";
        product2.price = 8;
        product2.quantity = 10;

        Product product3 = new Product();
        product3._name = "mango";
        product2._productId = "003";
        product3.price = 3;
        product3.quantity = 6;

        Order order1 = new Order();
        order1.customer = customer1;
        order1.products.Add(product1);
        order1.products.Add(product2);
        order1.products.Add(product3);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
    }
}