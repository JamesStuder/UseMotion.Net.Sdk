using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class ListTasks
    {
        /// <summary>
        /// List of tasks
        /// </summary>
        [JsonProperty("tasks")]
        public required List<Task> Tasks { get; set; }

        /// <summary>
        /// Information about the result. Contains information necessary for pagination
        /// </summary>
        [JsonProperty("meta")]
        public MetaResult? Meta { get; set; }
    }
}