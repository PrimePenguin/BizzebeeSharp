using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class MediaFileModelItem
    {
        [JsonProperty("data")]
        public MediaFileModel Data { get; set; } = new MediaFileModel();
    }
}