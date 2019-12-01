public class Person
{
    public string Name { get; set; }

    public Address Address { get; set; }

    public Person(string name, string city, string postalCode):
        base(city, postalCode)
    {
        Name = name;
    }
}

public class Address
{
    public string City { get; set; }

    public string PostalCode { get; set; }

    public Address(string city, string postalCode)
    {
        City = city;
        PostalCode = postalCode;
    }
}
