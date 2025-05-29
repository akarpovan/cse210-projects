using System;

public class Product
{
    //Attributes
    private string _productName;
    private double _productId;
    private double _productPrice;
    private int _productQuantity;

    //Constructor
    public Product(string name, double id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _productPrice = price;
        _productQuantity = quantity;
    }
    // Method
    public string GetProductName()
    {
        return _productName;
    }
    // Method
    public void SetProductName(string productName)
    {
        _productName = productName;
    }
    // Method
    public double GetProductId()
    {
        return _productId;
    }
    // Method
    public void SetProductId(double id)
    {
        _productId = id;
    }
    // Method
    public double GetProductPrice()
    {
        return _productPrice;
    }
    // Method
    public void SetProductPrice(double price)
    {
        _productPrice = price;
    }
    // Method
    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    // Method
    public void SetProductQuantity(int quantity)
    {
        _productQuantity = quantity;
    }
    // Method
    public double GetTotalCostOfProduct()
    {
        //The total cost of this product is computed by multiplying the price per unit and the quantity. 
        //(If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
        double totalCostProduct = 0;
        totalCostProduct = _productPrice * _productQuantity;
        return totalCostProduct;
    }

}
