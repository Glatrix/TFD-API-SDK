namespace TfdApiSDK.Models.Game
{
    public class IModule
    {
        public string module_name { get; set; }
        public string module_id { get; set; }
        public string image_url { get; set; }
        public string module_type { get; set; }
        public string module_tier { get; set; }
        public string module_socket_type { get; set; }
        public string module_class { get; set; }
        public IModuleStat[] module_stat { get; set; }
    }

}