using Sellix.net.API;
using Sellix.net.API.Categories;
using Sellix.net.API.Categories.Models;
using Sellix.net.Helpers;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sellix.net
{
    public class Sellix
    {
        public readonly string _apiUrl;
        public readonly HttpClient _httpClient;

        public Sellix(string secret, HttpClient httpClient, string apiUrl = "https://dev.sellix.io/v1")
        {
            _apiUrl = apiUrl;
            _httpClient = httpClient;
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", secret);
        }
    }
    public static class SellixWrapper
    {
        #region Categories
        public static async Task<Response<Categories>> GetCategories(this Sellix instance) => (await ParseHelper.ParseResponse<Response<Categories>>(await RequestHelper.Get("/categories", instance))).Data;
        #endregion
    }
}
