# The First Descendant API SDK
An Unofficial dotnet / csharp SDK for [Nexon's OpenAPI for The First Descendant](https://openapi.nexon.com/game/tfd/?id=20)

Work In Progress. Feel free to make pull requests to improve. Example code worked for me :)

Credit To [FraWolf's Typescript Version](https://github.com/FraWolf/tfd-api) for some of the models

```csharp
using TfdApiSDK;
using TfdApiSDK.Models.General;
using TfdApiSDK.Models.Account;
using TfdApiSDK.Models.Game;
using System.Web;
using System.Text.Json;

namespace YourApp
{
    internal class Program
    {
        private const string KEY = "test_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
        private const string USERNAME = "User#1234";

        static async Task Main(string[] args)
        {
            APIClient client = new TfdApiSDK.APIClient(KEY, throwOnSdkError: true);

            // MetaData API
            //APIResponse<IDescendant[]>? DescendantMetadata = await client.metadataAPI.GetDescendantMetadata();
            //APIResponse<IWeapon[]>? WeaponMetadata = await client.metadataAPI.GetWeaponMetadata();
            APIResponse<IModule[]>? ModuleMetadata = await client.metadataAPI.GetModuleMetadata();
            //APIResponse<IReactor[]>? ReactorMetadata = await client.metadataAPI.GetReactorMetadata();
            //APIResponse<IExternalComponent[]>? ExternalComponentMetadata = await client.metadataAPI.GetExternalComponentMetadata();
            //APIResponse<IReward[]>? RewardMetadata = await client.metadataAPI.GetRewardMetadata();
            //APIResponse<IStat[]>? StatMetadata = await client.metadataAPI.GetStatMetadata();
            //APIResponse<IVoidBattle[]>? VoidBattleMetadata = await client.metadataAPI.GetVoidBattleMetadata();
            //APIResponse<ITitle[]>? TitleMetadata = await client.metadataAPI.GetTitleMetadata();

            // Account API
            APIResponse<User>? UserOUID = await client.accountAPI.GetUserOUID(USERNAME);
            string? ouid = UserOUID?.Value.ouid;

            if(ouid is null) { return; }

            APIResponse<UserBasic>? UserBasicInfo = await client.accountAPI.GetUserBasicInfo(ouid);
            APIResponse<UserDescendant>? UserDescendantInfo = await client.accountAPI.GetUserDescendantInfo(ouid);
            APIResponse<UserWeapon>? UserWeaponInfo = await client.accountAPI.GetUserWeaponInfo(ouid);
            APIResponse<UserReactor>? UserReactorInfo = await client.accountAPI.GetUserReactorInfo(ouid);
            APIResponse<ExternalComponent>? UserExternalComponent = await client.accountAPI.GetUserExternalComponent(ouid);

            string? descendant_id = UserDescendantInfo?.Value.descendant_id;
            string? weapon_id = UserWeaponInfo?.Value.weapon[0].weapon_id; // first (top slot) weapon ID
            string? void_battle_id = "651000001"; // Grave Walker
            QueryPeriod period = QueryPeriod.Last7Days;

            if (descendant_id is null || weapon_id is null || void_battle_id is null) { return; }

            APIResponse<RecommendationModule>? RecommendationModule = 
                await client.accountAPI.GetRecommendationModule(descendant_id, weapon_id, void_battle_id, period);

            if(RecommendationModule?.Value.descendant.recommendation.Length == 0) { return; }

            string? module_id = RecommendationModule?.Value.descendant.recommendation[0].module_id;
            string? module_name = ModuleMetadata?.Value.FirstOrDefault((mod) => mod.module_id == module_id)?.module_name;
            Console.WriteLine($"The Module You Should Pick Is: {module_name ?? "N/A"}");
        }
    }
}
```
