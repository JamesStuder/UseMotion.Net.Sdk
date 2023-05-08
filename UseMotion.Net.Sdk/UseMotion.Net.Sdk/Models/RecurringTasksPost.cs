﻿using System;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class RecurringTasksPost
{
    /// <summary>
    /// Frequency in which the task should be scheduled. Please carefully read how to construct above.
    /// </summary>
    [JsonProperty("frequency")]
    public required string Frequency { get; set; }

    /// <summary>
    /// Default = SOFT. Allowed values: SOFT, HARD
    /// </summary>
    [JsonProperty("deadlineType")]
    public string? DeadlineType { get; set; }

    /// <summary>
    /// A duration can be one of the following... "REMINDER", or a integer greater than 0
    /// </summary>
    [JsonProperty("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// ISO 8601 Date which is trimmed to the start of the day passed. Example: 2023-04-20
    /// </summary>
    [JsonProperty("startingOn")]
    public DateTime? StartingOn { get; set; }

    /// <summary>
    /// Preferred time to start the recurring task.
    /// </summary>
    [JsonProperty("idealTime")]
    public string? IdealTime { get; set; }

    /// <summary>
    /// Schedule the task must adhere to.  Default = 'Work Hours'.
    /// </summary>
    [JsonProperty("schedule")]
    public string? Schedule { get; set; }

    /// <summary>
    /// Name / title of the task
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Id of the workspace the task should be created in
    /// </summary>
    [JsonProperty("workspaceId")]
    public required string WorkspaceId { get; set; }

    /// <summary>
    /// Description of the recurring task
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Default = MEDIUM.  Allowed values: MEDIUM, HIGH
    /// </summary>
    [JsonProperty("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// The user id the task should be assigned too
    /// </summary>
    [JsonProperty("assigneeId")]
    public string? AssigneeId { get; set; }
}