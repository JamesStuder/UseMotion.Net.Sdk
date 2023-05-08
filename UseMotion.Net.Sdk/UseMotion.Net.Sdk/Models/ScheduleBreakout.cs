using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class ScheduleBreakout
{
    /// <summary>
    /// Array could be empty if there is no range for this day
    /// </summary>
    [JsonProperty("monday")]
    public required List<DailySchedule> Monday { get; set; }

    /// <summary>
    /// Array could be empty if there is no range for this day
    /// </summary>
    [JsonProperty("tuesday")]
    public required List<DailySchedule> Tuesday { get; set; }

    /// <summary>
    /// Array could be empty if there is no range for this day
    /// </summary>
    [JsonProperty("wednesday")]
    public required List<DailySchedule> Wednesday { get; set; }

    /// <summary>
    /// Array could be empty if there is no range for this day
    /// </summary>
    [JsonProperty("thursday")]
    public required List<DailySchedule> Thursday { get; set; }

    /// <summary>
    /// Array could be empty if there is no range for this day
    /// </summary>
    [JsonProperty("friday")]
    public required List<DailySchedule> Friday { get; set; }

    /// <summary>
    /// Array could be empty if there is no range for this day
    /// </summary>
    [JsonProperty("saturday")]
    public required List<DailySchedule> Saturday { get; set; }

    /// <summary>
    /// Array could be empty if there is no range for this day
    /// </summary>
    [JsonProperty("sunday")]
    public required List<DailySchedule> Sunday { get; set; }
}