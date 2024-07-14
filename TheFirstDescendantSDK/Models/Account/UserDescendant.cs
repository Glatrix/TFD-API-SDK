namespace TfdApiSDK.Models.Account
{
    public class UserDescendant
    {
        public string ouid { get; set; }
        public string user_name { get; set; }
        public string descendant_id { get; set; }
        public string descendant_slot_id { get; set; }
        public float descendant_level { get; set; }
        public float module_max_capacity { get; set; }
        public float module_capacity { get; set; }
        public UserModule[] module { get; set; }
    }
}
