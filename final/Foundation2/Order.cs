public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    private double _shippingCost;


public void SetCustomer(Customer customer) {
        _customer = customer;
}

    public void AddProduct(Product product)
    {
        _products.Add(product);
        SetShippingCost();
    }
    public string TotalCostPerOrder() {
        double totalPrice = _products.Sum(product => product.TotalCost());

        return $"Total Cost for this order: ${totalPrice}";
    }

    public void PackingLabel() {

        Console.WriteLine($"Product ID    | Product Name |  Price ($ USD)  | Quantity  |  Subtotal");
        foreach (var product in _products)
        {
            Console.WriteLine($"{product.GetId()}        |     {product.GetName()}     |    ${product.GetPrice()}    |     {product.GetQuantity()}     |      ${product.TotalCost()} ");
        }
        Console.WriteLine("_________________________________________________");
        Console.WriteLine($"{TotalCostPerOrder()}");
    }


    public void ShippingLabel() {
        
        Console.WriteLine($"{_customer.GetCustomerName()}: \n {_customer.GetAddress()}");
        Console.WriteLine("");
    }
    public void SetShippingCost() {
        if (_customer.LiveInUSA())
        {
            _shippingCost = 5;
        }
        else {
            _shippingCost = 35;
        }
    
    }
}
