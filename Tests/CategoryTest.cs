using Sellix.Net.Models.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Sellix.Net;

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
            var createCat = sellix.CreateCategory(category);
            Assert.Equal(200, createCat.Status);
            Assert.NotNull(createCat.Data.UniqueId);

            //Edit category
            category.Title = "Test1";
            var updateCat = sellix.UpdateCategory(category, createCat.Data.UniqueId);
            Assert.Equal(200, updateCat.Status);

            //Get category
            var getCat = sellix.GetCategory(category.UniqueId);
            Assert.Equal(200, getCat.Status);
            Assert.Equal("Test1", getCat.Data.Category.Title);

            var deleteCat = sellix.DeleteCategory(getCat.Data.Category);
            Assert.Equal(200, deleteCat.Status);
        }
    }
}
