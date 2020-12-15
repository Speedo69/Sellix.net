using System;
using Sellix.net;
using Sellix.net.Models.Products;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your token goes here, very nice.
            var sellix = new Sellix.net.Sellix(Token.GetToken(), new System.Net.Http.HttpClient());
            var prod = new Product();
            prod.Title = "MegaTest";
            prod.Description = "I like Cock";
            prod.Price = 10f;
            prod.Gateways = new object[] { "PAYPAL" };
            prod.Type = ProductType.Service;
            prod.DiscountValue = 10f;
            var resp = sellix.CreateProduct(prod);
        }
    }
}
