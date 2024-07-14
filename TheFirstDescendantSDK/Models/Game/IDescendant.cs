namespace TfdApiSDK.Models.Game
{
    public class IDescendant
    {
        public string descendant_id { get; set; }
        public string descendant_name { get; set; }
        public string descendant_image_url { get; set; }
        public IDescendantStat[] descendant_stat { get; set; }
        public IDescendantSkill[] descendant_skill { get; set; }
    }

}