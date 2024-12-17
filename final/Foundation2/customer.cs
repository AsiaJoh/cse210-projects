class Customer
{
    string _customerName;
    Address _address;

    // Constructor(s)
    public Customer()
    {
        // Assigning the default values
        _customerName = "Larry the Cucumber";
        _address = new Address();
    }

    // Method(s)
    public bool USALiving(Address address) 
    {
        // Returns a boolean true/false - true if you live in the USA, false otherwise
        // Use Address class for this

        return address.USA();
    }

    // Getters/Setters
    public string GetCustomerName() 
    {
        return _customerName;
    }

    public void SetCustomerName(string customerName) 
    {
        _customerName = customerName;
    }

    public Address GetAddress() 
    {
        return _address;
    }

    public void SetAddress(Address address) 
    {
        _address = address;
    }
}