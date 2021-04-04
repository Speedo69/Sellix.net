using Sellix.Net.Helpers;
using Sellix.Net.Models;
using Sellix.Net.Models.Categories;

namespace Sellix.Net.Endpoints
{
    public class Categories
    {
        private readonly Sellix instance;
        public Categories(Sellix instance)
        {
            this.instance = instance;
        }

        public Response<CategoryList> GetCategories() => ParseHelper.ParseResponse<CategoryList>(RequestHelper.Get("/categories", instance).Result).Result;
        public Response<CategoryRoot> GetCategory(string uniqueId) => ParseHelper.ParseResponse<CategoryRoot>(RequestHelper.Get("/categories/" + uniqueId, instance).Result).Result;
        public Response<UniqId> CreateCategory(Category category) => RequestHelper.Post("/categories", instance, ParseHelper.ParseRequest(category).Result).Result;
        public Response<UniqId> UpdateCategory(Category category) => RequestHelper.Put("/categories/" + category.UniqueId, instance, ParseHelper.ParseRequest(category).Result).Result;
        public Response<UniqId> UpdateCategory(Category category, string uniqueId) { category.UniqueId = uniqueId; return UpdateCategory(category); }
        public Response<object> DeleteCategory(string uniqueId) => RequestHelper.Delete("/categories/" + uniqueId, instance).Result;
        public Response<object> DeleteCategory(Category category) => DeleteCategory(category.UniqueId);
    }
}
