using System;

public class Address
{
    // Variables
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address (string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Function to see if the address is inside the USA or not
    public bool InUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Function that returns the full address to the user at the end of the order
    public string GetFullAddress()
    {
        return $"{_street};\n{_city}, {_state} - {_country}\n";
    }
}