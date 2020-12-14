using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sellix.net.Helpers
{
    public static class RequestHelper
    {
        internal static async Task<string> Get(string endpoint, Sellix instance)
        {
            string url = instance._apiUrl + endpoint;
            return await (await instance._httpClient.GetAsync(url)).Content.ReadAsStringAsync();
        }
        internal static Task<HttpResponseMessage> Post(string endpoint, Sellix instance, string json)
        {
            string url = instance._apiUrl + endpoint;
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return Task.FromResult(instance._httpClient.PostAsync(url, content).Result);
        }
        internal static Task<HttpResponseMessage> Put(string endpoint, Sellix instance, string json)
        {
            string url = instance._apiUrl + endpoint;
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return Task.FromResult(instance._httpClient.PutAsync(url, content).Result);
        }
        internal static void Delete(string endpoint, Sellix instance)
        {
            string url = instance._apiUrl + endpoint;
            instance._httpClient.DeleteAsync(url);
        }
    }
}
