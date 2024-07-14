namespace TfdApiSDK.Models.Game
{
    public class IReactor
    {
        public string reactor_id { get; set; }
        public string reactor_name { get; set; }
        public string image_url { get; set; }
        public string reactor_tier { get; set; }
        public IReactorSkillPower[] reactor_skill_power { get; set; }
        public string optimized_condition_type { get; set; }
    }

}