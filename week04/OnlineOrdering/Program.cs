using System;

class Program
{
    static void Main()
    {
        // Products (name, id, price, quantity)
        Product product1 = new Product("Smartphone", "P348", 570, 2);
        Product product2 = new Product("Notebook Gamer", "P954", 1000, 1);
        Product product3 = new Product("WebCam", "P262", 120, 4);

        Product product4 = new Product("RAM Memory", "P483", 780, 1);
        Product product5 = new Product("Pen Drive", "P715", 12, 2);

        // Customers (name, address: street, neighbourhood. state, country)
        Customer customer1 = new Customer("Bryan Santana", new Address("987 Main Street", "Brooklyn", "NY", "USA"));
        Customer customer2 = new Customer("William Doe", new Address("1426 St Seven", "Alphaville", "PR", "Brazil"));

        // Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        //Displaying details
        Console.WriteLine();
        Console.WriteLine("- ORDER 1 -\n");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price (Without shipping price): ${order1.GetTotalCostWithoutShipping():F2}");
        Console.WriteLine($"Total Price (Shipping price included): ${order1.GetTotalCost():F2}\n");

        Console.WriteLine("=======================================================");

        Console.WriteLine("\n- ORDER 2 -\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price (Without shipping price): ${order2.GetTotalCostWithoutShipping():F2}");
        Console.WriteLine($"Total Price (Shipping price included): ${order2.GetTotalCost():F2}\n");
    }
}