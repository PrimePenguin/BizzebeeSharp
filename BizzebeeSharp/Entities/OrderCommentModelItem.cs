using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class OrderCommentModelItem
    {
        [JsonProperty("data")]
        public OrderCommentModel Data { get; set; } = new OrderCommentModel();
    }
}