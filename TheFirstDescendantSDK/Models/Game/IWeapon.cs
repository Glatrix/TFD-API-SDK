namespace TfdApiSDK.Models.Game
{
    public class IWeapon
    {
        public string weapon_name { get; set; }
        public string weapon_id { get; set; }
        public string image_url { get; set; }
        public string weapon_type { get; set; }
        public string weapon_tier { get; set; }
        public string weapon_rounds_type { get; set; }
        public IWeaponBaseStat[] base_stat { get; set; }
        public IWeaponFirearmAtk[] firearm_atk { get; set; }
        public string weapon_perk_ability_name { get; set; }
        public string weapon_perk_ability_description { get; set; }
    }

}