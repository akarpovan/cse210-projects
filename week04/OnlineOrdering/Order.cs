using System;

public class Order
{
    //Attributes
    private List<Product> _products;
    private Customer _customer;

    //Constructor   
    public Order(Customer customer)
    {
        _customer = customer;
        //Initialize list
        _products = new List<Product>();
    }
    // Method
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    // Method
    public double GetTotalCostOfOrder()
    {
        double totalCost = 0;
        double productTotal = 0;

        // Product costs
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCostOfProduct();
        }

        // Shipping cost based on customer location
        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;

        totalCost = productTotal + shippingCost;
        return totalCost;
    }
    // Method
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
            packingLabel += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";
        return packingLabel;
    }
    // Method
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().GetDispĺayAddress()}";
        return shippingLabel;
    }
    // Method
    public void GetDisplayOrder(Order order, string orderName)
    {
        Console.WriteLine($"{orderName}:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCostOfOrder():0.00}");
        Console.WriteLine("_______________________________________________\n");
    }
}
