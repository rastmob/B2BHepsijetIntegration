
using System.Net.Http.Headers;
using System.Text;
using B2BHepsijetIntegration.Application.Interfaces;
using B2BHepsijetIntegration.Domain.Models;
using Newtonsoft.Json;

namespace B2BHepsijetIntegration.Infrastructure.Services;

public class HepsijetAuthService : IHepsijetAuthService
{
    private readonly HttpClient _httpClient;

    public HepsijetAuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetTokenAsync(string username, string password)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://integration-apitest.hepsijet.com/auth/getToken");
        var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var jsonString = await response.Content.ReadAsStringAsync();
        var tokenResponse = JsonConvert.DeserializeObject<HepsijetTokenResponse>(jsonString);

        return tokenResponse?.Data?.Token;
    }
}
