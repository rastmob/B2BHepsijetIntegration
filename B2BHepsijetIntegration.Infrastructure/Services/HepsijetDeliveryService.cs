using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using B2BHepsijetIntegration.Application.Interfaces;
using B2BHepsijetIntegration.Domain.Models;
using Newtonsoft.Json;

namespace B2BHepsijetIntegration.Infrastructure.Services;

public class HepsijetDeliveryService : IHepsijetDeliveryService
{
    private readonly HttpClient _httpClient;

    public HepsijetDeliveryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> SendDeliveryAdvanceAsync(DeliveryAdvanceRequest request, string token)
    {
        var json = JsonConvert.SerializeObject(request);
        var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

        var httpRequest = new HttpRequestMessage(HttpMethod.Post, "https://integration-apitest.hepsijet.com/advance/sendDeliveryAdvance/v2");
        httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        httpRequest.Headers.Add("X-Auth-Token", token);
        httpRequest.Content = httpContent;

        var response = await _httpClient.SendAsync(httpRequest);
        var responseBody = await response.Content.ReadAsStringAsync();

        return responseBody;
    }
}
