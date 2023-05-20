using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class Schedule
    {
        /// <summary>
        /// Name of the schedule
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Uses the default timezone
        /// </summary>
        [JsonProperty("isDefaultTimezone", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefaultTimezone { get; set; }

        /// <summary>
        /// Timezone of the schedule
        /// </summary>
        [JsonProperty("timezone")]
        public required string Timezone { get; set; }

        /// <summary>
        /// Schedule broken out by day. It is possible for a day to have more than one start/end time
        /// </summary>
        [JsonProperty("schedule")]
        public required ScheduleBreakout Schedules { get; set; }
    }
}