namespace TfdApiSDK.Models.Game
{
    public class IReactorSkillPower
    {
        public float level { get; set; }
        public float skill_atk_power { get; set; }
        public float sub_skill_atk_power { get; set; }
        public IReactorPowerCoefficient[] skill_power_coefficient { get; set; }
        public IReactorEnchantEffect[] enchant_effect { get; set; }
    }

}