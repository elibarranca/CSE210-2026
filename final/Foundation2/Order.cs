class Order
{
    public List<Product> products = new List<Product>();
    public Customer customer = new Customer();

    public float GetTotalCost()
    {
        float total = 0;
        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }
        if (customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += product._name + " " + product._productId + "\n";
        }
        return label;
    }



    public string GetShippingLabel()
    {
        return customer._name + "\n" + customer._address.GetFullAddress();
    }
}