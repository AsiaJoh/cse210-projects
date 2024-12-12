class Customer
{
    string _customerName;
    Address _address;

    // Nested class Address
    class Address
    {
        string _streetAddress;
        string _city;
        string _state;
        string _country;

        // Constructor(s)
        public Address() {
            // Assigning the default values
        }

        // Method(s)
        public bool USA(string country) {

        }

        public string addressString(string streetAddress, string city, string state, string country) {

        }

        // Getter(s)/Setter(s)
    }


    // Constructor(s)
    public Customer()
    {
        // Assigning the default values

    }

    // Method(s)
    public bool USALiving(Address address) {

    }

    // Getters/Setters
    public string GetCustomerName() {

    }

    public void SetCustomerName(string customerName) {

    }
}