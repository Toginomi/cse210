class Product
{
    private string name;
    private int productId;
    private float price;
    private int quantity;

    public Product(string name, int productId, float price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public float CalculateTotalCost()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public int GetProductId()
    {
        return productId;
    }
}
