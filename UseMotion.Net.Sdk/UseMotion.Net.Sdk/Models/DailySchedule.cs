using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class DailySchedule
{
    /// <summary>
    /// 24 hour time format. HH:mm
    /// </summary>
    [JsonProperty("start")]
    public required string Start { get; set; }

    /// <summary>
    /// 24 hour time format. HH:mm
    /// </summary>
    [JsonProperty("end")]
    public required string End { get; set; }
}