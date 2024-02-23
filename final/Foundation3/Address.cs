public class Address
{
    private string _stretAddress;
    private string _city;
    private string _stateprovince;
    private string _country;


    public Address(string stretAddress, string city, string stateprovince, string country)
    {
        _stretAddress = stretAddress;
        _city = city;
        _stateprovince = stateprovince;
        _country = country;
    }

    public bool isInUSA() {
        if (_country == "USA" || _country == "Usa" || _country == "usa")
        {
            return true;
        }
        else {
            return false;
        }
    }

    public string GetFullAddress() {
        return $"{_stretAddress}, {_city}, {_stateprovince}, {_country}";
        
    }

}