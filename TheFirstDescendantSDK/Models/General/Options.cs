using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TfdApiSDK.Models.General
{
    public class Options
    {
        public string? api_key { get; set; }
        public string? default_language { get; set; }
    }

    public class ClientOptions
    {
        public string host;
        public string default_language;
        public Dictionary<string, string> headers { get; set; }

        public ClientOptions(string key)
        {
            headers = new Dictionary<string, string>()
            {
                { "x-nxopen-api-key", key }
            };
        }
    }

    public class APIResponse<T>
    {
        public Error? Error;
        public T Value;
        public bool HasValue;

        public static async Task<APIResponse<T>?> FromHttpResponseMessage(HttpResponseMessage? response)
        {
            if (response == null || !response.IsSuccessStatusCode)
            {
                return new APIResponse<T>() { HasValue = false, Error = new Error() { name = "SDK Error", message = "Non-Success Status Code" } };
            }

            string body = await response.Content.ReadAsStringAsync();
            T? obj = JsonSerializer.Deserialize<T>(body);

            if(obj is null)
            {
                return new APIResponse<T>() { HasValue = false, Error = new Error() { name = "SDK Error", message = "Failed To Parse Json" } };
            }

            return new APIResponse<T>() { Value = obj, HasValue = true };
        }
    }
}
