using System;

public class Customer
{
    //Attributes
    private string _customerName;
    private Address _customerAddress;

    //Constructor
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _customerAddress = address;

    }
    // Method
    public string GetCustomerName()
    {
        return _customerName;
    }
    // Method
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
    // Method
    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }
    // Method
    public void SetCustomerAddress(Address address)
    {
        _customerAddress = address;
    }

    //The customer should have a method that can return whether they live in the USA or not. 
    //(Hint this should call a method on the address to find this.)
    // Method
    public bool LivesInUSA()
    {
        return _customerAddress.GetIndicatorUSA();
    }


}
