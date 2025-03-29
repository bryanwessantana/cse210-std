using System;

public class Product
{
    // Variables
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // Function that gets the total cost (shipping included)
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Function that gets the packing label (name + id)
    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productID})";
    }
}