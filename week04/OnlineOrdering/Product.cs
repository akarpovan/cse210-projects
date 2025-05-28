using System;

public class Product
{
    private string _productName;
    private double _productId;
    private double _productPrice;
    private int _productQuantity;

    public Product()
    { 
    }

    public Product(string name, double id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _productPrice = price;
        _productQuantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public double GetProductId()
    {
        return _productId;
    }

    public void SetProductId(double id)
    {
        _productId = id;
    }

    public double GetProductPrice()
    {
        return _productPrice;
    }

    public void SetProductPrice(double price)
    {
        _productPrice = price;
    }

    public int GetProductQuantity()
    {
        return _productQuantity;
    }

    public void SetProductQuantity(int quantity)
    {
        _productQuantity = quantity;
    }

    public double GetTotalCostOfProduct()
    {
        //The total cost of this product is computed by multiplying the price per unit and the quantity. 
        //(If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
        double totalCostProduct = 0;
        totalCostProduct = _productPrice * _productQuantity;
        return totalCostProduct;
    }

}
