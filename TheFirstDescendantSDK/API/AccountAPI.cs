using TfdApiSDK.Models.Account;
using TfdApiSDK.Models.Game;
using TfdApiSDK.Models.General;

namespace TfdApiSDK
{
    public class AccountAPI : BaseAPI
    {
        public AccountAPI(string url, Dictionary<string, string> headers, bool throwOnSdkError, string language = "en")
            : base(url, headers, throwOnSdkError, language) { }


        /// <summary>
        /// Retrieve user identifier (OUID)
        /// </summary>
        /// <param name="user_name">Nickname</param>
        /// <returns>The OUID of the User</returns>
        public async Task<APIResponse<User>?> GetUserOUID(string user_name)
        {
            return await Request<User>($"{_url}/tfd/v1/id", new Dictionary<string, object>()
            {
                { "user_name", user_name }
            });
        }

        /// <summary>
        /// Retrieves basic User information.
        /// </summary>
        /// <param name="ouid">The OUID of the User</param>
        /// <returns>basic user information</returns>
        public async Task<APIResponse<UserBasic>?> GetUserBasicInfo(string ouid)
        {
            return await Request<UserBasic>($"{_url}/tfd/v1/user/basic", new Dictionary<string, object>()
            {
                { "ouid", ouid }
            });
        }

        /// <summary>
        /// Retrieves information about the equipped descendant.
        /// </summary>
        /// <param name="ouid">The OUID of the User</param>
        /// <returns>information about the equipped descendant.</returns>
        public async Task<APIResponse<UserDescendant>?> GetUserDescendantInfo(string ouid)
        {
            return await Request<UserDescendant>($"{_url}/tfd/v1/user/descendant", new Dictionary<string, object>()
            {
                { "ouid", ouid }
            });
        }

        /// <summary>
        /// Retrieves information about weapons equipped in all slots.
        /// </summary>
        /// <param name="ouid">The OUID of the User</param>
        /// <param name="language">language code</param>
        /// <returns>information about weapons equipped in all slots.</returns>
        public async Task<APIResponse<UserWeapon>?> GetUserWeaponInfo(string ouid, string language = "en")
        {
            return await Request<UserWeapon>($"{_url}/tfd/v1/user/weapon", new Dictionary<string, object>()
            {
                { "ouid", ouid },
                { "language_code", language }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ouid">The OUID of the User</param>
        /// <param name="language">language code</param>
        /// <returns></returns>
        public async Task<APIResponse<UserReactor>?> GetUserReactorInfo(string ouid, string language = "en")
        {
            return await Request<UserReactor>($"{_url}/tfd/v1/user/reactor", new Dictionary<string, object>()
            {
                { "ouid", ouid },
                { "language_code", language }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ouid">The OUID of the User</param>
        /// <param name="language">language code</param>
        /// <returns></returns>
        public async Task<APIResponse<ExternalComponent>?> GetUserExternalComponent(string ouid, string language = "en")
        {
            return await Request<ExternalComponent>($"{_url}/tfd/v1/user/external-component", new Dictionary<string, object>()
            {
                { "ouid", ouid },
                { "language_code", language }
            });
        }

        /// <summary>
        /// Recommends modules suited to the user.
        /// </summary>
        /// <param name="descendant_id">Descendant identifier(Refer to /meta/descendant API)</param>
        /// <param name="weapon_id">Weapon identifier(Refer to /meta/weapon API)</param>
        /// <param name="void_battle_id">Void Intercept Battle identifier(Refer to /meta/void-battle API)</param>
        /// <param name="period">Query period</param>
        /// <returns></returns>
        public async Task<APIResponse<RecommendationModule>?> GetRecommendationModule(
                string descendant_id, string weapon_id, string void_battle_id, QueryPeriod period
            )
        {
            return await Request<RecommendationModule>($"{_url}/tfd/v1/recommendation/module", new Dictionary<string, object>()
            {
                { "descendant_id", descendant_id },
                { "weapon_id", weapon_id },
                { "void_battle_id", void_battle_id },
                { "period", (byte)period }
            });
        }
    }


}
