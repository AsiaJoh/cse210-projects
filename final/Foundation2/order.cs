class Order
{
    Customer _customer;
    List<Product> _productList = new List<Product> {};
    

    // Constructor(s)
    public Order()
    {
        // Assigning the default values
        _customer = new Customer();

    }

    // Methods
    public float TotalCost(float pricePerUnit, int quantity) {
        // Calculate the total cost of the order
        // The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.

        float baseCost = pricePerUnit * quantity;

        float shippingCost;

        // Assign the customer's address
        Address address = _customer.GetAddress();

        // If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
        if (_customer.USALiving(address)) {
            shippingCost = 5;
        }
        else {
            shippingCost = 35;
        }

        // Find and return total cost
        float totalCost = baseCost + shippingCost;
        return totalCost;
    }

    public string PackingLabel() {
        // A packing label should list the name and product id of each product in the order.

        // Initialize packing label
        string packingLabel = $"Product Name(s):\n";

        foreach (Product product in _productList) {
            string productName = product.GetProductName();
            packingLabel += $"{productName}\n";
        }

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
    public void SetCustomer(Customer customer) {
        _customer = customer;
    }

    public List<Product> GetProductList() {
        return _productList;
    }
    public void SetProductList(List<Product> productList) {
        _productList = productList;
    }
}