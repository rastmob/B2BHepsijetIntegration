using System.Threading.Tasks;

namespace B2BHepsijetIntegration.Application.Interfaces;

public interface IHepsijetAuthService
{
    Task<string> GetTokenAsync(string username, string password);
}
