using System.Threading.Tasks;
using B2BHepsijetIntegration.Domain.Models;

namespace B2BHepsijetIntegration.Application.Interfaces;

public interface IHepsijetDeliveryService
{
    Task<string> SendDeliveryAdvanceAsync(DeliveryAdvanceRequest request, string token);
}
