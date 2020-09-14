using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class WebHookModelCollection
    {
        /// <summary>A list of web hooks</summary>
        [JsonProperty("data")]
        public ICollection<WebHookModel> Data { get; set; } =
            new Collection<WebHookModel>();
    }
}