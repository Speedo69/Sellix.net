using Sellix.net.API;
using Sellix.net.API.Categories.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sellix.net.Helpers
{
    public static class ParseHelper
    {
        public static Task<Response<T>> ParseResponse<T>(string json)
        {
            var response = JsonSerializer.Deserialize<Response<T>>(json);
            var u = response as Categories;
            return Task.FromResult(response);
        }
    }
}
