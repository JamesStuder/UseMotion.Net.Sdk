using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace UseMotion.Net.Sdk.DataAccess;

public class ApiAccess
{
    private HttpClient Client { get; }
    internal ApiAccess(string apiKey)
    {
        Client = new HttpClient();
        Client.BaseAddress = new Uri("https://api.usemotion.net/v1");
        Client.DefaultRequestHeaders.Clear();
        Client.DefaultRequestHeaders.Add("X-API-Key", apiKey);
    }

    internal async Task<string> PostAsync(string endpoint, string json)
    {
        StringContent content = new (json, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await Client.PostAsync(endpoint, content);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"PostAsync Error: {response.StatusCode} for endpoint {endpoint}");
            
        }
        return await response.Content.ReadAsStringAsync();
    }
    
    internal async Task<string> PatchAsync(string endpoint, string json)
    {
        StringContent content = new (json, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await Client.PatchAsync(endpoint, content);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"PatchAsync Error: {response.StatusCode} for endpoint {endpoint}");
            
        }
        return await response.Content.ReadAsStringAsync();
    }
    
    internal async Task<string> GetAsync(string endpoint, Dictionary<string, string>? queryParameters = null)
    {
        UriBuilder uriBuilder = new (new Uri(Client.BaseAddress!, endpoint));
        
        if (queryParameters != null)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(uriBuilder.Query);
            foreach (KeyValuePair<string, string> param in queryParameters)
            {
                query[param.Key] = param.Value;
            }
            uriBuilder.Query = query.ToString();
        }
        
        string urlWithParams = uriBuilder.ToString();
        
        HttpResponseMessage response = await Client.DeleteAsync(urlWithParams);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"GetAsync Error: {response.StatusCode} for endpoint {endpoint}");
            
        }
        return await response.Content.ReadAsStringAsync();
    }
    
    internal async Task<string> DeleteAsync(string endpoint)
    {
        HttpResponseMessage response = await Client.DeleteAsync(endpoint);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"DeleteAsync Error: {response.StatusCode} for endpoint {endpoint}");
            
        }
        return await response.Content.ReadAsStringAsync();
    }
}