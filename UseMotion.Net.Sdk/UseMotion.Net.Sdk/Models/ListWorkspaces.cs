using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class ListWorkspaces
{
    /// <summary>
    /// List of workspaces
    /// </summary>
    [JsonProperty("workspaces")]
    public required List<Workspace> Workspaces { get; set; }

    /// <summary>
    /// Information about the result. Contains information necessary for pagination
    /// </summary>
    [JsonProperty("meta")]
    public MetaResult? Meta { get; set; }
}