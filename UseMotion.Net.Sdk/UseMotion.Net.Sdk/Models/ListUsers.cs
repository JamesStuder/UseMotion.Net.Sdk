using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class ListUsers
    {
        /// <summary>
        /// List of users
        /// </summary>
        [JsonProperty("users")]
        public required List<User> Users { get; set; }

        /// <summary>
        /// Information about the result. Contains information necessary for pagination
        /// </summary>
        [JsonProperty("meta")]
        public MetaResult? Meta { get; set; }
    }
}