class Product
{
    public string _name = "";
    public string _productId = "";
    public float price = 0;
    public int quantity = 0;

    public float GetTotalCost()
    {
        return price * quantity;
    }

}