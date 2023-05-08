using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class Status
    {
        /// <summary>
        /// Name of the status
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Is the status set as a default status
        /// </summary>
        [JsonProperty("isDefaultStatus")]
        public required bool IsDefaultStatus { get; set; }

        /// <summary>
        /// Is the status set as a resolved status
        /// </summary>
        [JsonProperty("isResolvedStatus")]
        public required bool IsResolvedStatus { get; set; }
    }
}