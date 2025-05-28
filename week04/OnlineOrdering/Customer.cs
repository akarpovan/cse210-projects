using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer()
    {
    }

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _customerAddress = address;

    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
    
    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }

    public void SetCustomerAddress(Address address)
    {
        _customerAddress = address;
    }


    //The customer should have a method that can return whether they live in the USA or not. 
    //(Hint this should call a method on the address to find this.)

    public bool LivesInUSA()
    {
        return _customerAddress.GetIndicatorUSA();
    }


}
