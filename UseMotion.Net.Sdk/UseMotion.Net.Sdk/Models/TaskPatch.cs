﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class TaskPatch
{
    /// <summary>
    /// ISO 8601 Due date on the task. REQUIRED for scheduled tasks. Example: 2023-04-20T15:02:30.321-06:00
    /// </summary>
    [JsonProperty("dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// A duration can be one of the following... "NONE", "REMINDER", or a integer greater than 0
    /// </summary>
    [JsonProperty("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// Defaults to workspace default status
    /// </summary>
    [JsonProperty("status")]
    public string? Status { get; set; }

    /// <summary>
    /// If value is defined, the "status" field must be either "Auto-Scheduled" or left blank
    /// </summary>
    [JsonProperty("autoScheduled")]
    public AutoScheduledInfo? AutoScheduled { get; set; }

    /// <summary>
    /// Name of the task
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Id of the project the task belongs to
    /// </summary>
    [JsonProperty("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// Input as GitHub Flavored Markdown
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Allowed values: LOW, MEDIUM, HIGH, ASAP
    /// </summary>
    [JsonProperty("priority")]
    public string? Priority { get; set; }

    /// <summary>
    /// Labels linked to task
    /// </summary>
    [JsonProperty("labels")]
    public List<string>? Labels { get; set; }

    /// <summary>
    /// The user id the task should be assigned to
    /// </summary>
    [JsonProperty("assigneeId")]
    public string? AssigneeId { get; set; }
}