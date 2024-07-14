using TfdApiSDK.Models.General;

namespace TfdApiSDK
{
    public class APIClient
    {
        private ClientOptions options;

        public AccountAPI accountAPI;
        public MetadataAPI metadataAPI;

        public APIClient(string key, bool throwOnSdkError = false, string language = "en")
        {
            options = new ClientOptions(key)
            {
                host = "https://open.api.nexon.com",
                default_language = language
            };

            accountAPI = new AccountAPI(options.host, options.headers, throwOnSdkError, language);
            metadataAPI = new MetadataAPI(options.host, options.headers, throwOnSdkError, language);
        }
    }


}
