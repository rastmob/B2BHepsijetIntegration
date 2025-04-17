namespace B2BHepsijetIntegration.Domain.Models;

public class DeliveryAdvanceRequest
{
    public string OrderId { get; set; }
    public string OrderDate { get; set; }
    public Receiver Receiver { get; set; }
    public List<Delivery> Deliveries { get; set; }
}

public class Receiver
{
    public string CompanyCustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone1 { get; set; }
    public string Email { get; set; }
}

public class Delivery
{
    public SenderCompany SenderCompany { get; set; }
    public string DeliveryType { get; set; }
    public string DeliverySlot { get; set; }
    public string Desi { get; set; }
    public Product Product { get; set; }
    public Address SenderAddress { get; set; }
    public Address RecipientAddress { get; set; }
}

public class SenderCompany
{
    public string Name { get; set; }
    public string AbbreviationCode { get; set; }
    public string AccountId { get; set; }
    public List<string> ContactEmails { get; set; }
}

public class Product
{
    public string ProductCode { get; set; }
}

public class Address
{
    public string CompanyAddressId { get; set; }
    public Location Country { get; set; }
    public Location City { get; set; }
    public Location Town { get; set; }
    public Location District { get; set; }
    public string AddressLine1 { get; set; }
}

public class Location
{
    public string Name { get; set; }
}
