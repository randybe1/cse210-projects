using System;

namespace Foundation3
{
    public class Address
    {
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public Address(string street, string city, string state, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;

    }

    public string DisplayAddress()
    {
        string _address = $"{_street}\n{_city}, {_state}, {_zipCode}";
        return _address;
    }

}
}