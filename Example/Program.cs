using System;
using Sellix.net;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var sellix = new Sellix.net.Sellix(Token.GetToken(), new System.Net.Http.HttpClient());
            var s = sellix.GetCategories();
            var u = sellix.GetCategory(s.Data.Categories[1].UniqueId);
            //sellix.CreateCategory(new Sellix.net.API.Categories.Models.Category(false, "test2", 0, null));
            var t = u.Data.Category.GetProducts();
            var l = sellix.GetProduct(t[0].UniqueId);
            var ul = sellix.GetProdcuts();
        }
    }
}
