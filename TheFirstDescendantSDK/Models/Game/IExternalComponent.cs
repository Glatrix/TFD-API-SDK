namespace TfdApiSDK.Models.Game
{
    public class IExternalComponent
    {
        public string external_component_id { get; set; }
        public string external_component_name { get; set; }
        public string image_url { get; set; }
        public string external_component_equipment_type { get; set; }
        public string external_component_tier { get; set; }
        public IExternalComponentBaseStat[] base_stat { get; set; }
        public IExternalComponentSetOptionDetail[] set_option_detail { get; set; }
    }

}