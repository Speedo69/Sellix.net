using System;
using Sellix.net;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
           var sellix = new Sellix.net.Sellix("xD7Wu9DzvbTd6xVmZPQ96sL0dq8bpJjTvPQ3aD7fySLWzSq2nrThzBKtPKzDXoso", new System.Net.Http.HttpClient());
            //var s = sellix.GetCategories();
            //var u = sellix.GetCategory(s.Data.categories[0].UniqueId);
            sellix.CreateCategory(new Sellix.net.API.Categories.Models.Category(false, "test2", 0, null));
        }
    }
}
