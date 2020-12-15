using Sellix.net.API;
using Sellix.net.API.Categories.Models;
using Sellix.net.Helpers;
using Sellix.net.Models.Blacklist;
using Sellix.net.Models.Coupons;
using Sellix.net.Models.Feedback;
using Sellix.net.Models.Products;
using System.Net.Http;
using System.Text.Json;

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
        public static Response<dynamic> CreateProduct(this Sellix instance, Product product) => RequestHelper.Post("/products", instance, ParseHelper.ParseRequest(product).Result).Result;
        public static void UpdateProduct(this Sellix instance, Product product) => RequestHelper.Put("/products", instance, ParseHelper.ParseRequest(product).Result);
        public static void DeleteProduct(this Sellix instance, string uniqueId) => RequestHelper.Delete("/products/" + uniqueId, instance);
        #endregion
        #region Feedback
        public static Response<FeedbackRoot> GetFeedback(this Sellix instance, string uniqueId) => ParseHelper.ParseResponse<FeedbackRoot>(RequestHelper.Get("/feedback/" + uniqueId, instance).Result).Result;
        public static Response<FeedbackList> GetFeedbacks(this Sellix instance) => ParseHelper.ParseResponse<FeedbackList>(RequestHelper.Get("/feedback", instance).Result).Result;
        public static void ReplyFeedback(this Sellix instance, string uniqueId, string reply) => RequestHelper.Post("/feedback/" + uniqueId, instance, JsonSerializer.Serialize(new { reply = reply }));
        #endregion
        #region Coupon
        public static Response<CouponRoot> GetCoupon(this Sellix instance, string uniqueId) => ParseHelper.ParseResponse<CouponRoot>(RequestHelper.Get(" /coupons/" + uniqueId, instance).Result).Result;
        public static Response<CouponList> GetCoupons(this Sellix instance) => ParseHelper.ParseResponse<CouponList>(RequestHelper.Get("/coupons", instance).Result).Result;
        public static void CreateCoupon(this Sellix instance, Coupon coupon) => RequestHelper.Post("/coupons", instance, ParseHelper.ParseRequest(coupon).Result);
        public static void UpdateCoupon(this Sellix instance, Coupon coupon) => RequestHelper.Put("/coupons/", instance, ParseHelper.ParseRequest(coupon).Result);
        public static void DeleteCoupon(this Sellix instance, string uniqueId) => RequestHelper.Delete("/coupons/" + uniqueId, instance);
        #endregion

        #region Blacklist
        public static Response<BlacklistRoot> GetBlacklist(this Sellix instance, string id) => ParseHelper.ParseResponse<BlacklistRoot>(RequestHelper.Get("/blacklist/" + id, instance).Result).Result;
        public static Response<BlacklistList> GetBlacklists(this Sellix instance) => ParseHelper.ParseResponse<BlacklistList>(RequestHelper.Get("/blacklist", instance).Result).Result;
        public static void CreateBlacklist(this Sellix instance, Blacklist blacklist) => RequestHelper.Post("/blacklist", instance, ParseHelper.ParseRequest(blacklist).Result);
        public static void UpdateBlacklist(this Sellix instance, Blacklist blacklist, string uniqueId) => RequestHelper.Put("/blacklists/" + uniqueId, instance, ParseHelper.ParseRequest(blacklist).Result);
        
        #endregion
    }
}
