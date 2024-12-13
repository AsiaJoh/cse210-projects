class Address
{
    string _streetAddress;
    string _city;
    string _state;
    string _country;

    // Constructor(s)
    public Address() {
        // Assigning the default values
        _streetAddress = "1234 Avenue Lane";
        _city = "Rexburg";
        _state = "Idaho";
        _country = "USA";
    }

    // Method(s)
    public bool USA() {
        // Determine if the address is in the USA

        // I believe this returns true when the statement is true, and false otherwise
        return "USA" == _country;
    }

    public string addressString() {
        // return a string all of its fields together in one string

        string address = $"{_streetAddress} \n{_city}, {_state} \n{_country}";
        return address;
    }

    // Getter(s)/Setter(s)
    public string GetStreetAddress() {
        return _streetAddress;
    }
    public string GetCity() {
        return _city;
    }
    public string GetState() {
        return _state;
    }
    public string GetCountry() {
        return _country;
    }


    public void SetStreetAddress(string streetAddress) {
        _streetAddress = streetAddress;
    }
    public void SetCity(string city) {
        _city = city;
    }
    public void SetState(string state) {
        _state = state;
    }
    public void SetCountry(string country) {
        _country = country;
    }
}