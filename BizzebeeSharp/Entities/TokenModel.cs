using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class TokenModel
    {
        /// <summary>The Access Token to use in future requests</summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>The scope this access token is valid for</summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }

        /// <summary>The number of seconds until this access token expires</summary>
        [JsonProperty("expires_in")]
        public int? ExpiresIn { get; set; }
    }
}