using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class ListProjects
    {
        /// <summary>
        /// List of projects
        /// </summary>
        [JsonProperty("projects")]
        public required List<Project> Projects { get; set; }

        /// <summary>
        /// Information about the result. Contains information necessary for pagination
        /// </summary>
        [JsonProperty("meta")]
        public MetaResult? Meta { get; set; }
    }
}