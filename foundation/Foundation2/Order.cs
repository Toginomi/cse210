class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public float CalculateTotalCost()
    {
        float totalCost = 0;

        foreach (var product in products)
        {
            totalCost += product.CalculateTotalCost();
        }

        float shippingCost = customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $" - {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label.Trim();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}