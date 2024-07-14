using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TheFirstDescendantSDK.API
{
    public static class Utils
    {
        public static string formatUrlWithArgs(string url, Dictionary<string, object>? args)
        {
            NameValueCollection queryString = HttpUtility.ParseQueryString(string.Empty);

            if(args != null && args.Count > 0)
            {
                foreach (KeyValuePair<string, object> arg in args)
                {
                    queryString.Add(arg.Key, arg.Value.ToString());
                }
            }
            return $"{url}?{queryString.ToString()}"; // Returns "key1=value1&key2=value2", all URL-encoded
        }

        public static async Task<HttpResponseMessage?> httpGetRequest(string url, Dictionary<string, string>? headers = null)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);

                if(headers != null)
                {
                    foreach (var header in headers)
                    {
                        req.Headers.Add(header.Key, header.Value);
                    }
                }

                return await client.SendAsync(req);
            }
        }
    }
}
