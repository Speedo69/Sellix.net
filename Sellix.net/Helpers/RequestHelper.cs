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
    }
}
