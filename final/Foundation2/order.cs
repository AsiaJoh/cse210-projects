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
        
    }

    public string PackingLabel() {
        
    }

    public string ShippingLabel() {

    }


    // Getters/Setters
    public string GetCustomer() {
        return _customer;
    }
    public List<Product> GetProductList() {
        return _productList;
    }
}