public class Customer
{
    private string _customerName;
    private Address _address;


    public Customer(string name, Address address){
        _customerName = name;
        _address = address;
    }

    public bool LiveInUSA() {
        return _address.isInUSA();
    }

    public string GetAddress() {
        return _address.GetFullAddress();
    }

    public string GetCustomerName() {

        return $"{_customerName}";
    }

}