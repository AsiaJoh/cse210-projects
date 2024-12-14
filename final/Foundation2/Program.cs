using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that creates at least two orders with a 2-3 products each. 

        // -- First Order Creation --
        Order order1 = new Order();

        // Make a reference to first order's customer
        Customer customer1 = order1.GetCustomer();

        // Set up first order's customer
        customer1.SetCustomerName("Mary Jane");

        // Make a reference to first order's customer's address
        Address address1 = customer1.GetAddress();

        // Set up first order's customer's address
        address1.SetStreetAddress("4321 NW Happy Drive");
        address1.SetCity("Chicago");
        address1.SetState("Iowa");
        address1.SetCountry("USA");

        // Make first order's first product
        Product stuffedAnimal = new Product();

        stuffedAnimal.SetProductName("Lizard Stuffed Animal");
        stuffedAnimal.SetProductID(640164829);
        stuffedAnimal.SetPricePerUnit(10.5f);
        stuffedAnimal.SetQuantity(3);
        // Add this product to the customer's list
        order1.addProductToList(stuffedAnimal);

        // Make first order's second product
        Product actionFigure = new Product();

        actionFigure.SetProductName("Superman Ultimate Action Figure");
        actionFigure.SetProductID(333666999);
        actionFigure.SetPricePerUnit(5f);
        actionFigure.SetQuantity(1);
        // Add this product to the customer's list
        order1.addProductToList(actionFigure);


        // -- Second Order Creation --
        Order order2 = new Order();

        // Make a reference to second order's customer
        Customer customer2 = order2.GetCustomer();

        // Set up second order's customer
        customer2.SetCustomerName("Yiddles Yodles");

        // Make a reference to second order's customer's address
        Address address2 = customer2.GetAddress();

        // Set up second order's customer's address
        address2.SetStreetAddress("3334 SE Sad Avenue");
        address2.SetCity("London");
        address2.SetState("Greater London");
        address2.SetCountry("UK");

        // Make second order's first product
        Product polishedRocks = new Product();

        polishedRocks.SetProductName("Small Bag of Polished Rocks");
        polishedRocks.SetProductID(222444666);
        polishedRocks.SetPricePerUnit(15f);
        polishedRocks.SetQuantity(5);
        // Add this product to the customer's list
        order2.addProductToList(polishedRocks);

        // Make second order's second product
        Product hairbrush = new Product();

        hairbrush.SetProductName("Curly Hair Special Hairbrush");
        hairbrush.SetProductID(102938475);
        hairbrush.SetPricePerUnit(20f);
        hairbrush.SetQuantity(1);
        // Add this product to the customer's list
        order2.addProductToList(hairbrush);

        // Make second order's third product
        Product glowsticks = new Product();

        glowsticks.SetProductName("Bag of 12in Glowsticks");
        glowsticks.SetProductID(789123456);
        glowsticks.SetPricePerUnit(5f);
        glowsticks.SetQuantity(4);
        // Add this product to the customer's list
        order2.addProductToList(glowsticks);


        // Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.

        // -- First order methods--

        // First order's packing label
        string order1PackingLabel = order1.PackingLabel();

        // First order's shipping label
        string order1ShippingLabel = order1.ShippingLabel();

        // First order's total price
        float order1TotalPrice = order1.TotalPrice();

        // First order display
        Console.WriteLine("----------");
        Console.WriteLine($"Thank you for shopping, {customer1.GetCustomerName()}! Here is your order:");
        string order1Display = $"Packing Label: \n{order1PackingLabel} \nShipping Label: \n{order1ShippingLabel} \nTotal Price: ${order1TotalPrice:F2}";
        Console.WriteLine(order1Display);

        Console.WriteLine();
        Console.WriteLine();

        // -- Second order methods--

        // Second order's packing label
        string order2PackingLabel = order2.PackingLabel();

        // Second order's shipping label
        string order2ShippingLabel = order2.ShippingLabel();

        // Second order's total price
        float order2TotalPrice = order2.TotalPrice();

        // Second order display
        Console.WriteLine("----------");
        Console.WriteLine($"Thank you for shopping, {customer2.GetCustomerName()}! Here is your order:");
        string order2Display = $"Packing Label: \n{order2PackingLabel} \nShipping Label: \n{order2ShippingLabel} \nTotal Price: ${order2TotalPrice:F2}";
        Console.WriteLine(order2Display);
    }
}