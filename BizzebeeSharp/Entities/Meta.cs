using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class Meta
    {
        [JsonProperty("pagination")]
        public PaginationModel Pagination { get; set; } = new PaginationModel();
    }
}