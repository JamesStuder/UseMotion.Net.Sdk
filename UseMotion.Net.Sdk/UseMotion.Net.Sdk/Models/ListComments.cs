using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class ListComments
    {
        /// <summary>
        /// List of comments
        /// </summary>
        [JsonProperty("comments")]
        public required List<Comment> Comments { get; set; }

        /// <summary>
        /// Information about the result. Contains information necessary for pagination
        /// </summary>
        [JsonProperty("meta")]
        public MetaResult? Meta { get; set; }
    }
}