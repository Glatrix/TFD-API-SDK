using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Numerics;
using TfdApiSDK.Models.Account;
using TfdApiSDK.Models.Game;
using TfdApiSDK.Models.General;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TfdApiSDK
{
    public class MetadataAPI : BaseAPI
    {
        public MetadataAPI(string url, Dictionary<string, string> headers, bool throwOnSdkError, string language = "en")
            : base(url, headers, throwOnSdkError, language) { }

        public async Task<APIResponse<IDescendant[]>?> GetDescendantMetadata(string language_code = "en")
        {
            return await Request<IDescendant[]>($"{_url}/static/tfd/meta/{language_code}/descendant.json");
        }

        public async Task<APIResponse<IWeapon[]>?> GetWeaponMetadata(string language_code = "en")
        {
            return await Request<IWeapon[]>($"{_url}/static/tfd/meta/{language_code}/weapon.json");
        }

        public async Task<APIResponse<IModule[]>?> GetModuleMetadata(string language_code = "en")
        {
            return await Request<IModule[]>($"{_url}/static/tfd/meta/{language_code}/module.json");
        }

        public async Task<APIResponse<IReactor[]>?> GetReactorMetadata(string language_code = "en")
        {
            return await Request<IReactor[]>($"{_url}/static/tfd/meta/{language_code}/reactor.json");
        }

        public async Task<APIResponse<IExternalComponent[]>?> GetExternalComponentMetadata(string language_code = "en")
        {
            return await Request<IExternalComponent[]>($"{_url}/static/tfd/meta/{language_code}/external-component.json");
        }

        public async Task<APIResponse<IReward[]>?> GetRewardMetadata(string language_code = "en")
        {
            return await Request<IReward[]>($"{_url}/static/tfd/meta/{language_code}/reward.json");
        }

        public async Task<APIResponse<IStat[]>?> GetStatMetadata(string language_code = "en")
        {
            return await Request<IStat[]>($"{_url}/static/tfd/meta/{language_code}/stat.json");
        }

        public async Task<APIResponse<IVoidBattle[]>?> GetVoidBattleMetadata(string language_code = "en")
        {
            return await Request<IVoidBattle[]>($"{_url}/static/tfd/meta/{language_code}/void-battle.json");
        }

        public async Task<APIResponse<ITitle[]>?> GetTitleMetadata(string language_code = "en")
        {
            return await Request<ITitle[]>($"{_url}/static/tfd/meta/{language_code}/title.json");
        }
    }
}