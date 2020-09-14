using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class WebHookModelItem
    {
        [JsonProperty("data")]
        public WebHookModel Data { get; set; } = new WebHookModel();
    }
}