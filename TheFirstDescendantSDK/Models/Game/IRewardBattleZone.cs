namespace TfdApiSDK.Models.Game
{
    public class IRewardBattleZone
    {
        public string battle_zone_id { get; set; }
        public string battle_zone_name { get; set; }
        public IRewardBattleZoneReward[] reward { get; set; }
    }

}