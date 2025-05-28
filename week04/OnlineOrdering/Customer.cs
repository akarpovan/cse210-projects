using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer()
    { 
    }

    public Customer(string customerName)
    {
        _customerName = customerName;
        //Initialize object
        _customerAddress = new Address();

    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }


    //The customer should have a method that can return whether they live in the USA or not. 
    //(Hint this should call a method on the address to find this.)


}
