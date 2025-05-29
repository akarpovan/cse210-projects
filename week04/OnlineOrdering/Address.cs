using System;

public class Address
{
    //Attributes
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    //Constructor
    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _stateProvince = state;
        _country = country;
    }
    // Method
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    // Method
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    // Method
    public string GetCity()
    {
        return _city;
    }
    // Method
    public void SetCity(string city)
    {
        _city = city;
    }
    // Method
    public string GetStateProvince()
    {
        return _stateProvince;
    }
    // Method
    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }
    // Method
    public string GetCountry()
    {
        return _country;
    }
    // Method
    public void SetCountry(string country)
    {
        _country = country;
    }
    // Method
    public bool GetIndicatorUSA()
    {
        bool indicatorUSA = false; //It's not from the USA
        //The address should have a method that can return whether it is in the USA or not.
        if (_country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES")
        {
            indicatorUSA = true; //It's from the USA
        }
        return indicatorUSA;
    }
    // Method
    public string GetDispĺayAddress()
    {
        //The address should have a method to return a string all of its fields together in one string 
        //(with newline characters where appropriate)
        string addr = "";
        addr = $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        return addr;
    }
}
