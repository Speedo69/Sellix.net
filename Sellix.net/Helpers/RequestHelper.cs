using Sellix.net.API;
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
        internal static Task<Response<dynamic>> Post(string endpoint, Sellix instance, string json)
        {
            string url = instance._apiUrl + endpoint;
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return Task.FromResult(ParseHelper.ParseResponse<dynamic>(instance._httpClient.PostAsync(url, content).Result.Content.ReadAsStringAsync().Result).Result);
        }
        internal static Task<HttpResponseMessage> Put(string endpoint, Sellix instance, string json)
        {
            string url = instance._apiUrl + endpoint;
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return Task.FromResult(instance._httpClient.PutAsync(url, content).Result);
        }
        internal static Task<HttpResponseMessage> Delete(string endpoint, Sellix instance)
        {
            string url = instance._apiUrl + endpoint;
           return Task.FromResult (instance._httpClient.DeleteAsync(url).Result);
        }
    }
}
