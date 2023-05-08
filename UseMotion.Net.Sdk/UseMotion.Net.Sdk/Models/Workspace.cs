using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class Workspace
{
    /// <summary>
    /// Identifier of the workspace
    /// </summary>
    [JsonProperty("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the workspace
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Identifier of the team
    /// </summary>
    [JsonProperty("teamId")]
    public string? TeamId { get; set; }

    /// <summary>
    /// Statuses of the workspace
    /// </summary>
    [JsonProperty("statuses")]
    public required List<Status> Statuses { get; set; }

    /// <summary>
    /// Labels of the workspace
    /// </summary>
    [JsonProperty("labels")]
    public required List<Label> Labels { get; set; }

    /// <summary>
    /// Type of the workspace
    /// </summary>
    [JsonProperty("type")]
    public required string Type { get; set; }
}