using Sellix.Net.Models.Categories;
using Xunit;
using Sellix.Net.Endpoints;

namespace Tests
{
    public class CategoryTest
    {
        [Fact]
        public void Test()
        {
            var sellix = new Sellix.Net.Sellix(Token.Get, new System.Net.Http.HttpClient());
            //Create new category
            var category = new Category(false, "Test", 0, new string[0]);
            var createCat = sellix.Categories.CreateCategory(category);
            Assert.Equal(200, createCat.Status);
            Assert.NotNull(createCat.Data.UniqueId);

            //Edit category
            category.Title = "Test1";
            var updateCat = sellix.Categories.UpdateCategory(category, createCat.Data.UniqueId);
            Assert.Equal(200, updateCat.Status);

            //Get category
            var getCat = sellix.Categories.GetCategory(category.UniqueId);
            Assert.Equal(200, getCat.Status);
            Assert.Equal("Test1", getCat.Data.Category.Title);

            var deleteCat = sellix.Categories.DeleteCategory(getCat.Data.Category);
            Assert.Equal(200, deleteCat.Status);
        }
    }
}
