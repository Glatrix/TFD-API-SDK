namespace TfdApiSDK.Models.Account
{
    public class UserReactor
    {
        public string ouid { get; set; }
        public string user_name { get; set; }
        public string reactor_id { get; set; }
        public string reactor_slot_id { get; set; }
        public float reactor_level { get; set; }
        public object? reactor_additional_stat { get; set; } // string[] maybe?
        public float reactor_enchant_level { get; set; }
    }
}
