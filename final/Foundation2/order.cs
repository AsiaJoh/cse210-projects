class Order
{
    Customer _customer;
    List<Product> _productList = new List<Product> {};
    

    // Constructor(s)
    public Order()
    {
        // Assigning the default values

    }

    // Methods
    public float TotalCost(float pricePerUnit, int quantity) {
        // Calculate the total cost of the order
        // The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
        // If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.

        float totalCost = pricePerUnit * quantity;
        return totalCost;
    }

    public string PackingLabel() {
        // A packing label should list the name and product id of each product in the order.
        string packingLabel = "Hello yes I am a packing label";

        // Return a string for the packing label
        return packingLabel;
    }

    public string ShippingLabel() {
        // Retrieve the customer's address
        Address address = _customer.GetAddress();

        string addressString = address.addressString();

        // A shipping label should list the name and address of the customer
        string shippingLabel = $"Customer Name: {_customer.GetCustomerName()} \nCustomer Address: \n{addressString}";

        // Return a string for the shipping label
        return shippingLabel;
    }


    // Getters/Setters
    public Customer GetCustomer() {
        return _customer;
    }
    public List<Product> GetProductList() {
        return _productList;
    }
}