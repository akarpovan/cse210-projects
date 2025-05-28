using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {
    }

    public Order(Customer customer)
    {
        _customer = customer;
        //Initialize list
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

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

    /*public double GetTotalPrice()
    {
        //The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
        double totalPrice = 0;
        //pending to do
        return totalPrice;
    }

    public double GetShippingCost(int indicator)
    {
        double shippingCost = 0;
        //This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. 
        //If the customer does not live in the USA, then the shipping cost is $35.
        if (indicator == 1) //the customer lives in the USA
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;

    }*/

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
            packingLabel += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().GetDispĺayAddress()}";
        return shippingLabel;
    }

    /*public string GetPackingLabel(Product product)
    {
        //A packing label should list the name and product id of each product in the order.
        Console.WriteLine($"Product name: {product.GetProductName()} - Product id: {product._id}");
    }

     public string GetShippingLabel(Customer customer)
    {
        //A shipping label should list the name and address of the customer.
        Console.WriteLine($"Customer name: {customer._name} - Customer address: {customer._address}");
    }*/

}
