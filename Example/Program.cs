using System;
using Sellix.Net;
using Sellix.Net.Models.Products;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your token goes here, very nice.
            var sellix = new Sellix.Net.Sellix(Token.GetToken(), new System.Net.Http.HttpClient());

        }
    }
}
