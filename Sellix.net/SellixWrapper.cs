using Sellix.Net.Helpers;
using Sellix.Net.Models;
using Sellix.Net.Models.Blacklist;
using Sellix.Net.Models.Categories;
using Sellix.Net.Models.Coupons;
using Sellix.Net.Models.Feedback;
using Sellix.Net.Models.Products;
using System.Net.Http;
using System.Text.Json;

namespace Sellix.Net
{
    //cool comment
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
    /// <summary>
    /// Extentsion methods for Sellix, contains the actual wrapping functionality.
    /// </summary>
    public static class SellixWrapper
    {
        #region Categories
        public static Response<CategoryList> GetCategories(this Sellix instance) => ParseHelper.ParseResponse<CategoryList>(RequestHelper.Get("/categories", instance).Result).Result;
        public static Response<CategoryRoot> GetCategory(this Sellix instance, string uniqueId) => ParseHelper.ParseResponse<CategoryRoot>(RequestHelper.Get("/categories/" + uniqueId, instance).Result).Result;
        public static Response<UniqId> CreateCategory(this Sellix instance, Category category) => RequestHelper.Post("/categories", instance, ParseHelper.ParseRequest(category).Result).Result;
        public static Response<UniqId> UpdateCategory(this Sellix instance, Category category) => RequestHelper.Put("/categories/" + category.UniqueId, instance, ParseHelper.ParseRequest(category).Result).Result;
        public static Response<UniqId> UpdateCategory(this Sellix instance, Category category, string uniqueId) { category.UniqueId = uniqueId; return UpdateCategory(instance, category); }
        public static Response<object> DeleteCategory(this Sellix instance, string uniqueId) => RequestHelper.Delete("/categories/" + uniqueId, instance).Result;
        public static Response<object> DeleteCategory(this Sellix instance, Category category) => DeleteCategory(instance, category.UniqueId);

        #endregion
        #region Products
        public static Response<ProductRoot> GetProduct(this Sellix instance, string uniqueId) => ParseHelper.ParseResponse<ProductRoot>(RequestHelper.Get("/products/" + uniqueId, instance).Result).Result;
        public static Response<ProductList> GetProdcuts(this Sellix instance) => ParseHelper.ParseResponse<ProductList>(RequestHelper.Get("/products", instance).Result).Result;
        public static Response<UniqId> CreateProduct(this Sellix instance, Product product) => RequestHelper.Post("/products", instance, ParseHelper.ParseRequest(product).Result).Result;
        public static Response<UniqId> UpdateProduct(this Sellix instance, Product product, string uniqueId) => RequestHelper.Put("/products/" + uniqueId, instance, ParseHelper.ParseRequest(product).Result).Result;
        public static Response<UniqId> UpdateProduct(this Sellix instance, Product product) => UpdateProduct(instance, product, product.UniqueId);
        public static Response<object> DeleteProduct(this Sellix instance, string uniqueId) => RequestHelper.Delete("/products/" + uniqueId, instance).Result;
        #endregion
        #region Feedback
        public static Response<FeedbackRoot> GetFeedback(this Sellix instance, string uniqueId) => ParseHelper.ParseResponse<FeedbackRoot>(RequestHelper.Get("/feedback/" + uniqueId, instance).Result).Result;
        public static Response<FeedbackList> GetFeedbacks(this Sellix instance) => ParseHelper.ParseResponse<FeedbackList>(RequestHelper.Get("/feedback", instance).Result).Result;
        public static Response<UniqId> ReplyFeedback(this Sellix instance, string uniqueId, string reply) => RequestHelper.Post("/feedback/" + uniqueId, instance, JsonSerializer.Serialize(new { reply })).Result;
        public static Response<UniqId> ReplyFeedback(this Sellix instance, Feedback feedback, string reply) => ReplyFeedback(instance, feedback.UniqueId, reply);
        #endregion
        #region Coupon
        public static Response<CouponRoot> GetCoupon(this Sellix instance, string uniqueId) => ParseHelper.ParseResponse<CouponRoot>(RequestHelper.Get(" /coupons/" + uniqueId, instance).Result).Result;
        public static Response<CouponList> GetCoupons(this Sellix instance) => ParseHelper.ParseResponse<CouponList>(RequestHelper.Get("/coupons", instance).Result).Result;
        public static void CreateCoupon(this Sellix instance, Coupon coupon) => RequestHelper.Post("/coupons", instance, ParseHelper.ParseRequest(coupon).Result);
        public static void UpdateCoupon(this Sellix instance, Coupon coupon) => RequestHelper.Put("/coupons/", instance, ParseHelper.ParseRequest(coupon).Result);
        public static void DeleteCoupon(this Sellix instance, string uniqueId) => RequestHelper.Delete("/coupons/" + uniqueId, instance);
        #endregion

        #region Blacklist
        public static Response<BlacklistRoot> GetBlacklist(this Sellix instance, string id) => ParseHelper.ParseResponse<BlacklistRoot>(RequestHelper.Get("/blacklists/" + id, instance).Result).Result;
        public static Response<BlacklistList> GetBlacklists(this Sellix instance) => ParseHelper.ParseResponse<BlacklistList>(RequestHelper.Get("/blacklists", instance).Result).Result;
        public static Response<UniqId> CreateBlacklist(this Sellix instance, Blacklist blacklist) => RequestHelper.Post("/blacklists", instance, ParseHelper.ParseRequest(blacklist).Result).Result;
        public static Response<UniqId> UpdateBlacklist(this Sellix instance, Blacklist blacklist, string uniqueId) { blacklist.UniqueId = uniqueId; return UpdateBlacklist(instance, blacklist); }
        public static Response<UniqId> UpdateBlacklist(this Sellix instance, Blacklist blacklist) => RequestHelper.Put("/blacklists/" + blacklist.UniqueId, instance, ParseHelper.ParseRequest(blacklist).Result).Result;
        public static Response<object> DeleteBlacklist(this Sellix instance, string uniqueId) => RequestHelper.Delete("/blacklists/" + uniqueId, instance).Result;
        public static Response<object> DeleteBlacklist(this Sellix instance, Blacklist blacklist) => DeleteBlacklist(instance, blacklist.UniqueId);
        #endregion
    }
}
