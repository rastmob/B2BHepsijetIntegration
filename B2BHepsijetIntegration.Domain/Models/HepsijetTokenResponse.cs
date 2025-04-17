namespace B2BHepsijetIntegration.Domain.Models;

public class HepsijetTokenResponse
{
    public string Status { get; set; }
    public HepsijetTokenData Data { get; set; }
}

public class HepsijetTokenData
{
    public string Token { get; set; }
}
