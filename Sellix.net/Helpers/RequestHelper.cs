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
            string url = instance.ApiUrl + endpoint;
            return await(await instance.HttpClient.GetAsync(url)).Content.ReadAsStringAsync();
        }
        internal static Task<Response<UniqId>> Post(string endpoint, Sellix instance, string json)
        {
            string url = instance.ApiUrl + endpoint;
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return ParseHelper.ParseResponse<UniqId>(instance.HttpClient.PostAsync(url, content).Result.Content.ReadAsStringAsync().Result);
        }
        internal static Task<Response<UniqId>> Put(string endpoint, Sellix instance, string json)
        {
            string url = instance.ApiUrl + endpoint;
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return ParseHelper.ParseResponse<UniqId>(instance.HttpClient.PutAsync(url, content).Result.Content.ReadAsStringAsync().Result);
        }
        internal static Task<Response<object>> Delete(string endpoint, Sellix instance)
        {
            string url = instance.ApiUrl + endpoint;
            return ParseHelper.ParseResponse<object>(instance.HttpClient.DeleteAsync(url).Result.Content.ReadAsStringAsync().Result);
        }
    }
}
