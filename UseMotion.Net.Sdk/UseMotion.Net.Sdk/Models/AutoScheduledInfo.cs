using System;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class AutoScheduledInfo
    {
        /// <summary>
        /// ISO 8601 Date which is trimmed to the start of the day passed.  Example: 2023-04-20
        /// </summary>
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// default = SOFT, Allowed Values: SOFT, HARD, NONE
        /// </summary>
        [JsonProperty("deadlineType")]
        public string? DeadlineType { get; set; }

        /// <summary>
        /// Schedule the task must adhere to. Schedule MUST be 'Work Hours' if scheduling the task for another user.
        /// </summary>
        [JsonProperty("schedule")]
        public required string Schedule { get; set; }
    }
}