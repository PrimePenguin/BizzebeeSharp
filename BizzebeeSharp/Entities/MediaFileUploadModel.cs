using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class MediaFileUploadModel
    {
        [JsonProperty("file")]
        public string File { get; set; }
    }
}