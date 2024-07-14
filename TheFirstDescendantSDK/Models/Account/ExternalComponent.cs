namespace TfdApiSDK.Models.Account
{
    public class ExternalComponent
    {
        public string external_component_slot_id { get; set; }
        public string external_component_id { get; set; }
        public float external_component_level { get; set; }
        public AdditionalStat[] external_component_additional_stat { get; set; }
    }
}
