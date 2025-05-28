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

    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _stateProvince = state;
        _country = country;
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

    public string GetDispĺayAddress()
    {
        //The address should have a method to return a string all of its fields together in one string 
        //(with newline characters where appropriate)
        string addr = "";
        addr = $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        return addr;
    }
}
