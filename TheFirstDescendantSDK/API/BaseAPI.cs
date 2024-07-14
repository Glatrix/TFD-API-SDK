using TfdApiSDK.Models.General;
using TheFirstDescendantSDK.API;

namespace TfdApiSDK
{
    public class BaseAPI
    {
        protected string _url;
        protected Dictionary<string, string> _headers;
        protected string _language;
        protected bool _throw;
        public BaseAPI(string url, Dictionary<string, string> headers, bool throwOnSdkError, string language = "en")
        {
            _url = url;
            _headers = headers;
            _language = language;
            _throw = throwOnSdkError;
        }

        protected async Task<APIResponse<T>?> Request<T>(string url, Dictionary<string, object>? args = null, Dictionary<string, string>? headers = null)
        {
            try
            {
                if(headers != null)
                {
                    _headers.ToList().ForEach(x => headers.Add(x.Key, x.Value));
                }
                else
                {
                    headers = _headers;
                }
                string format_url = Utils.formatUrlWithArgs(url, args);
                HttpResponseMessage? response = await Utils.httpGetRequest(format_url, headers);
                return await APIResponse<T>.FromHttpResponseMessage(response?.EnsureSuccessStatusCode());
            }
            catch(Exception e)
            {
                if (_throw)
                {
                    throw;
                }
                return new APIResponse<T>()
                {
                    Error = new Error() { name = "SDK Error", message = e.Message }
                };
            }
        }
    }
}
