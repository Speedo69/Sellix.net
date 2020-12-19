using Sellix.Net.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;
using Sellix.Net;
using Xunit;

namespace Tests
{
    public class ProductTest
    {
        [Fact]
        public void Test()
        {
            var sellix = new Sellix.Net.Sellix(Token.Get, new System.Net.Http.HttpClient());

            var product = new Product();
            product.Title = "Test";
            product.Description = "Test";
            product.Price = 10f;
            product.Gateways = new string[] { "PAYPAL" };
            product.Type = ProductType.Service;
            product.ServiceText = "Get scammed fool";
            product.DiscountValue = 0f;

            var createProd = sellix.CreateProduct(product);
            Assert.Equal(200, createProd.Status);
            Assert.NotNull(createProd.Data.UniqueId);

            var updateProd = sellix.UpdateProduct(product, createProd.Data.UniqueId);
            Assert.Equal(200, updateProd.Status);
            Assert.NotNull(updateProd.Data.UniqueId);

            var getProd = sellix.GetProduct(updateProd.Data.UniqueId);
            Assert.Equal(200, getProd.Status);
            Assert.NotNull(getProd.Data.Product);

            var deleteProd = sellix.DeleteProduct(getProd.Data.Product.UniqueId);
            Assert.Equal(200, deleteProd.Status);
        }
    }
}
