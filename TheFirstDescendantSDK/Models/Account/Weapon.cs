namespace TfdApiSDK.Models.Account
{
    //// --------------------------------------------------

    public class Weapon
    {
        public float module_max_capacity { get; set; }
        public float module_capacity { get; set; }
        public string weapon_slot_id { get; set; }
        public string weapon_id { get; set; }
        public float weapon_level { get; set; }
        public float? perk_ability_enchant_level { get; set; }
        public AdditionalStat[] weapon_additional_stat { get; set; }
        public UserModule[] module { get; set; }
    }
}
