using System;
using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Function that see if the user live inside the USA
    public bool LivesInUSA()
    {
        return _address.InUSA();
    }

    // Function that returns the full address
    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}