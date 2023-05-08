using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class Project
{
    /// <summary>
    /// Identifier of the project
    /// </summary>
    [JsonProperty("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the project
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Description of the project
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Id of the workspace this project belongs to
    /// </summary>
    [JsonProperty("workspaceId")]
    public string? WorkspaceId { get; set; }
}