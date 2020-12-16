using Sellix.Net.Models;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sellix.Net.Helpers
{
    internal static class RequestHelper
    {
        internal static async Task<string> Get(string endpoint, Sellix instance)
        {
            string url = instance._apiUrl + endpoint;
            return await (await instance._httpClient.GetAsync(url)).Content.ReadAsStringAsync();
        }
        internal static Task<Response<UniqId>> Post(string endpoint, Sellix instance, string json)
        {
            string url = instance._apiUrl + endpoint;
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return Task.FromResult(ParseHelper.ParseResponse<UniqId>(instance._httpClient.PostAsync(url, content).Result.Content.ReadAsStringAsync().Result).Result);
        }
        internal static Task<Response<UniqId>> Put(string endpoint, Sellix instance, string json)
        {
            string url = instance._apiUrl + endpoint;
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return Task.FromResult(ParseHelper.ParseResponse<UniqId>(instance._httpClient.PutAsync(url, content).Result.Content.ReadAsStringAsync().Result).Result);
        }
        internal static Task<Response<object>> Delete(string endpoint, Sellix instance)
        {
            string url = instance._apiUrl + endpoint;
            return Task.FromResult(ParseHelper.ParseResponse<object>(instance._httpClient.DeleteAsync(url).Result.Content.ReadAsStringAsync().Result).Result);
        }
    }
}
