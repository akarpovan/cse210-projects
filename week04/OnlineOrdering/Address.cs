using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address()
    {
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetStateProvince()
    {
        return _stateProvince;
    }

    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }
    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _stateProvince = state;
        _country = country;
    }


    public int GetIndicatorUSA()
    {
        //The address should have a method that can return whether it is in the USA or not.
        int indicatorUSA = 0;

        return indicatorUSA;
    }

    public string DispĺayAddress(Address address)
    {
        //The address should have a method to return a string all of its fields together in one string 
        //(with newline characters where appropriate)
        string addr = "";
        addr = $"{address._country}-{address._stateProvince}-{address._city}-{address._streetAddress}";
        return addr;
    }
}
