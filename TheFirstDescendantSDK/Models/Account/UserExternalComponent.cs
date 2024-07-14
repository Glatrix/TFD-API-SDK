namespace TfdApiSDK.Models.Account
{
    public class UserExternalComponent
    {
        public string ouid { get; set; }
        public string user_name { get; set; }
        public ExternalComponent[] external_component { get; set; }
    }
}
