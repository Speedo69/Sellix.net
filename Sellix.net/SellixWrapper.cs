using Sellix.net.API;
using Sellix.net.API.Categories.Models;
using Sellix.net.Helpers;
using Sellix.net.Models.Products;
using System.Net.Http;

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
        public static Response<CategoryList> GetCategories(this Sellix instance) => ParseHelper.ParseResponse<CategoryList>(RequestHelper.Get("/categories", instance).Result).Result;
        public static Response<CategoryRoot> GetCategory(this Sellix instance, string uniqueId) => ParseHelper.ParseResponse<CategoryRoot>(RequestHelper.Get("/categories/" + uniqueId, instance).Result).Result;
        public static void CreateCategory(this Sellix instance, Category category) => RequestHelper.Post("/categories", instance, ParseHelper.ParseRequest(category).Result);
        #endregion
        #region Products
        public static Response<ProductRoot> GetProduct(this Sellix instance, string uniqueId) => ParseHelper.ParseResponse<ProductRoot>(RequestHelper.Get("/products/" + uniqueId, instance).Result).Result;
        public static Response<ProductList> GetProdcuts(this Sellix instance) => ParseHelper.ParseResponse<ProductList>(RequestHelper.Get("/products", instance).Result).Result;
        public static void CreateProduct(this Sellix instance, Product product) => RequestHelper.Post("/products", instance, ParseHelper.ParseRequest(product).Result);
        public static void UpdateProduct(this Sellix instance, Product product) => RequestHelper.Put("/products", instance, ParseHelper.ParseRequest(product).Result);
        public static void DeleteProduct(this Sellix instance, string uniqueId) => RequestHelper.Delete("/products/" + uniqueId, instance);
        #endregion

    }
}
