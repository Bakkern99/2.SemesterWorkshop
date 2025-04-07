using System.Net.Http.Json;
using Shared;

namespace webapp2.Service;

public class TojServiceServer : ITojservice
{
    private string serverUrl = "http://localhost:5284";

    private HttpClient client;
    
    public TojServiceServer(HttpClient client)
    {
        this.client = client;
    }

    public async Task<Toj[]> GetAll()
    {
        return await client.GetFromJsonAsync<Toj[]>($"{serverUrl}/api/bike");
    }

    public async Task Add(Toj bike)
    {
        await client.PostAsJsonAsync<Toj>($"{serverUrl}/api/bike", bike);
    }

    public async Task DeleteById(int id)
    {
        await client.DeleteAsync($"{serverUrl}/api/bike/{id}");
    }
}