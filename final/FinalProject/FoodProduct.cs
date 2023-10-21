using System;

public class FoodProduct : Product
{   
    private string _expiryDate;

    public FoodProduct(string name, decimal price, string description, string type, string date) :
    base(name, description, price, type)
    {
        _expiryDate = date;
    }

    public string GetExpiryDate()
    {
        return _expiryDate;
    }
    
    public void SetExpiryDate(string date)
    {
        _expiryDate = date;
    }

    public override string ShowAvailableProducts()
    {
        return $"PRODUCT: {GetName()} || PRICE: ${GetPrice()} " +
        $"|| DESCRIPTION: {GetDescription()} || EXPIRY DATE: {GetExpiryDate()}\n ";
    }

    public override string GetProductInfo()
    {
        SetProductType("Food");
        return $"PRODUCT TYPE: {GetProductType()} || PRODUCT: {GetName()} || PRICE: ${GetPrice()} " +
        $"|| DESCRIPTION: {GetDescription()} || EXPIRY DATE: {GetExpiryDate()}\n";
    }
}