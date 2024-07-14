using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TfdApiSDK.Models.Game
{
    public enum QueryPeriod : byte
    {
        Last7Days = 0,
        Last30Days = 1,
        AllTime = 2,
    }

    public class RecommendationModule
    {
        public RecommendationModuleDescendant descendant { get; set; }
        public RecommendationModuleWeapon weapon { get; set; }
    }

    public class RecommendationModuleDescendant
    {
        public string descendant_id {get; set; }
        public RecommendationModuleRecommendation[] recommendation { get; set; }
    }

    public class RecommendationModuleWeapon
    {
       public string weapon_id { get; set; }
       public RecommendationModuleRecommendation[] recommendation { get; set; }
    }

    public class RecommendationModuleRecommendation
    {
        public string module_id { get; set; }
    }
}
