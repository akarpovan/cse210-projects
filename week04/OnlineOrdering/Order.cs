using System;

public class Order
{
    private string _packingLabel;
    private string _shippingLabel;

    private List<Product> _products;
    private List<Customer> _customers;

    public Order()
    {
    }

    public Order(string packingLabel, string shippingLabel)
    {
        _packingLabel = packingLabel;
        _shippingLabel = shippingLabel;
        //Initialize list
        _products = new List<Product>();
        _customers = new List<Customer>();

    }

    public string GetPackingLabel()
    {
        return _packingLabel;
    }

    public string GetShippingLabel()
    {
        return _shippingLabel;
    }

    public void SetPackingLabel(string packingLabel)
    {
        _packingLabel = packingLabel;
    }

    public void SetShippingLabel(string shippingLabel)
    {
        _shippingLabel = shippingLabel;
    }


    public double GetTotalCostOfOrder()
    {
        double totalCost = 0;
        //pending to do
        return totalCost;
    }

    public double GetTotalPrice()
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
