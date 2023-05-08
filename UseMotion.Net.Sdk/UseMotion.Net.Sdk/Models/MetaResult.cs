using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class MetaResult
    {
        /// <summary>
        /// Returned if there are more entities to return. Pass back with the cursor param set to continue paging
        /// </summary>
        [JsonProperty("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Maximum number of entities delivered per page
        /// </summary>
        [JsonProperty("pageSize")]
        public required int PageSize { get; set; }
    }
}