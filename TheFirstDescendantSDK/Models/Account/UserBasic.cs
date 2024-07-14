namespace TfdApiSDK.Models.Account
{
    public class UserBasic
    {
        public string ouid { get; set; }
        public string user_name { get; set; }
        public string platform_type { get; set; }
        public float mastery_rank_level { get; set; }
        public float mastery_rank_exp { get; set; }
        public string title_prefix_id { get; set; }
        public string title_suffix_id { get; set; }
        public string os_language { get; set; }
        public string game_language { get; set; }
    }
}
