using Sellix.Net.Helpers;
using Sellix.Net.Models;
using Sellix.Net.Models.Products;

namespace Sellix.Net.Endpoints
{
    public class Products
    {
        private readonly Sellix instance;

        public Products(Sellix instance)
        {
            this.instance = instance;
        }

        public Response<ProductRoot> GetProduct(string uniqueId) => ParseHelper.ParseResponse<ProductRoot>(RequestHelper.Get("/products/" + uniqueId, instance).Result).Result;
        public Response<ProductList> GetProdcuts() => ParseHelper.ParseResponse<ProductList>(RequestHelper.Get("/products", instance).Result).Result;
        public Response<UniqId> CreateProduct(Product product) => RequestHelper.Post("/products", instance, ParseHelper.ParseRequest(product).Result).Result;
        public Response<UniqId> UpdateProduct(Product product, string uniqueId) => RequestHelper.Put("/products/" + uniqueId, instance, ParseHelper.ParseRequest(product).Result).Result;
        public Response<UniqId> UpdateProduct(Product product) => UpdateProduct(product, product.UniqueId);
        public Response<object> DeleteProduct(string uniqueId) => RequestHelper.Delete("/products/" + uniqueId, instance).Result;
    }
}
