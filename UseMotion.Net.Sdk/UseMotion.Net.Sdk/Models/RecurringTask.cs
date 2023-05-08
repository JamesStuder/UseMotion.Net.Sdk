using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class RecurringTask
{
    /// <summary>
    /// Workspace the recurring task belongs to
    /// </summary>
    [JsonProperty("workspace")]
    public required Workspace Workspace { get; set; }

    /// <summary>
    /// Identifier of the recurring task
    /// </summary>
    [JsonProperty("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the recurring task
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Description of the recurring task
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// User who created the recurring task
    /// </summary>
    [JsonProperty("creator")]
    public required User Creator { get; set; }

    /// <summary>
    /// User assigned too
    /// </summary>
    [JsonProperty("assignee")]
    public required User Assignee { get; set; }

    /// <summary>
    /// Linked Project
    /// </summary>
    [JsonProperty("project")]
    public Project? Project { get; set; }

    /// <summary>
    /// Status of the recurring task
    /// </summary>
    [JsonProperty("status")]
    public required Status Status { get; set; }

    /// <summary>
    /// Priority of the recurring task. Can be one of: ASAP, High, Medium, Low
    /// </summary>
    [JsonProperty("priority")]
    public required string Priority { get; set; }

    /// <summary>
    /// Labels for the recurring task
    /// </summary>
    [JsonProperty("labels")]
    public required List<Label> Labels { get; set; }  
}