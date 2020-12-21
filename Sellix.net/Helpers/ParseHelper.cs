using Sellix.Net.Models;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sellix.Net.Helpers
{
    internal static class ParseHelper
    {
        public static Task<Response<T>> ParseResponse<T>(string json) => Task.FromResult(JsonSerializer.Deserialize<Response<T>>(json));
        public static Task<string> ParseRequest<T>(T requestModel) => Task.FromResult(JsonSerializer.Serialize(requestModel)); 
    }
}
