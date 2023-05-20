using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace UseMotion.Net.Sdk.DataAccess
{
    internal class ApiAccess
    {
        private HttpClient Client { get; }
        private string ApiKey { get; }
        private static string ApiVersion => "v1";
        
        internal ApiAccess(string apiKey)
        {
            ApiKey = apiKey;
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://api.usemotion.com/");
            Client.DefaultRequestHeaders.Add("X-API-Key", apiKey);
        }

        /// <summary>
        /// Post data to endpoint
        /// </summary>
        /// <param name="endpoint">Endpoint to call</param>
        /// <param name="json">Data to patch to endpoint</param>
        /// <returns>Json string from API with the requested data</returns>
        /// <exception cref="Exception">If not a success code from API will throw exception with status code received and the name of the endpoint</exception>
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
    
        /// <summary>
        /// Patch data to endpoint
        /// </summary>
        /// <param name="endpoint">Endpoint to call</param>
        /// <param name="json">Data to patch to endpoint</param>
        /// <returns>Json string from API with the requested data</returns>
        /// <exception cref="Exception">If not a success code from API will throw exception with status code received and the name of the endpoint</exception>
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
    
        /// <summary>
        /// Get data from endpoint
        /// </summary>
        /// <param name="endpoint">Endpoint to call</param>
        /// <param name="queryParameters">Default = null.  Pass in query parameter as key and the value of the parameter as the value</param>
        /// <returns>Json string from API with the requested data</returns>
        /// <exception cref="Exception">If not a success code from API will throw exception with status code received and the name of the endpoint</exception>
        internal async Task<string> GetAsync(string endpoint, Dictionary<string, string>? queryParameters = null)
        {
            if (queryParameters != null && queryParameters.Count > 0)
            {
                string query = string.Join("&", queryParameters.Select(kv => $"{Uri.EscapeDataString(kv.Key)}={Uri.EscapeDataString(kv.Value)}"));
                endpoint += $"?{query}";
            }
            
            HttpResponseMessage response = await Client.GetAsync($"{ApiVersion}{endpoint}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"GetAsync Error: {response.StatusCode} for endpoint {endpoint}");
            }
            return await response.Content.ReadAsStringAsync();
        }
    
        /// <summary>
        /// Delete data from endpoint
        /// </summary>
        /// <param name="endpoint">Endpoint to call</param>
        /// <returns>True if successful and false if not successful</returns>
        internal async Task<bool> DeleteAsync(string endpoint)
        {
            HttpResponseMessage response = await Client.DeleteAsync(endpoint);
            return response.IsSuccessStatusCode;
        }
    }
}