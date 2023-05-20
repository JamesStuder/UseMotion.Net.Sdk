﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class TaskPost
    {
        /// <summary>
        /// ISO 8601 Due date on the task. REQUIRED for scheduled tasks. Example: 2023-04-20T15:02:30.321-06:00
        /// </summary>
        [JsonProperty("dueDate", NullValueHandling=NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// A duration can be one of the following... "NONE", "REMINDER", or a integer greater than 0
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public object? Duration { get; set; }

        /// <summary>
        /// Defaults to workspace default status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; }

        /// <summary>
        /// If value is defined, the "status" field must be either "Auto-Scheduled" or left blank
        /// </summary>
        [JsonProperty("autoScheduled", NullValueHandling = NullValueHandling.Ignore)]
        public AutoScheduledInfo? AutoScheduled { get; set; }

        /// <summary>
        /// Name / title of the task
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Id of the project for the task
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string? ProjectId { get; set; } = string.Empty;

        /// <summary>
        /// Id of the workspace for the task
        /// </summary>
        [JsonProperty("workspaceId")]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Input as GitHub Flavored Markdown
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; }

        /// <summary>
        /// Default = MEDIUM.  Allowed values: LOW, MEDIUM, HIGH, ASAP
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string? Priority { get; set; } = string.Empty;

        /// <summary>
        /// Labels for the task
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Labels { get; set; }

        /// <summary>
        /// List of subtasks
        /// </summary>
        [JsonProperty("subTasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubTask>? SubTasks { get; set; }

        /// <summary>
        /// The user id the task should be assigned to
        /// </summary>
        [JsonProperty("assigneeId", NullValueHandling = NullValueHandling.Ignore)]
        public string? AssigneeId { get; set; }
    }
}