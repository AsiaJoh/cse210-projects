class Product
{
    string _productName;
    int _productID;
    float _pricePerUnit;
    int _quantity;  

    // Constructor(s)
    public Product()
    {
        // Assigning the default values

    }

    // Method(s)
    public float computeTotalCost() {
        // Total cost of this product is computed by multiplying the price per unit and the quantity.
        float totalCost = _pricePerUnit * _quantity;

        return totalCost;
    }

    // Getters/Setters
    public string GetName() {
        return _productName;
    }
    public int GetProductID() {
        return _productID;
    }
    public float GetPricePerUnit() {
        return _pricePerUnit;
    }
    public int GetQuantity() {
        return _quantity;
    }


    public void SetName(string productName) {
        _productName = productName;
    }
    public void SetProductID(int productID) {
        _productID = productID;
    }
    public void SetPricePerUnit(float pricePerUnit) {
        _pricePerUnit = pricePerUnit;
    }
    public void SetQuantity(int quantity) {
        _quantity = quantity;
    }

}