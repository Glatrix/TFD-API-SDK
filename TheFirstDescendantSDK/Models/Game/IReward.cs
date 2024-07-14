namespace TfdApiSDK.Models.Game
{
    public class IReward
    {
        public string map_id { get; set; }
        public string map_name { get; set; }
        public IRewardBattleZone[] battle_zone { get; set; }
    }

}