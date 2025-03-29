using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private double US_SHIPPING_COST = 5.0;
    private double INT_SHIPPING_COST = 35.0;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    // Function to add the products to a list
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Function to sum and return the total cost to the user without shipping cost
    public double GetTotalCostWithoutShipping()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        return total;
    }

    // Function that givees the total cost (with shipping)
    public double GetTotalCost()
    {
        return GetTotalCostWithoutShipping() + (customer.LivesInUSA() ? US_SHIPPING_COST : INT_SHIPPING_COST);
    }

    // Function to return the Packing Label List 
    public string GetPackingLabel()
    {
        string label = "Packing List: \n";
        foreach (var product in products)
        {
            label += $"- {product.GetPackingLabel()}\n";
        }
        return label;
    }

    // Function to return the shipping to the user
    public string GetShippingLabel()
    {
        double shippingCost = customer.LivesInUSA() ? US_SHIPPING_COST : INT_SHIPPING_COST;     
        return $"Shipping to: {customer.GetShippingLabel()}\nShipping Cost: ${shippingCost:F2}";
    }
}