using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class Task
    {
        /// <summary>
        /// A duration can be one of the following... "NONE", "REMINDER", or a integer greater than 0
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string? Duration { get; set; }

        /// <summary>
        /// Workspace task belongs to
        /// </summary>
        [JsonProperty("workspace")]
        public required Workspace? Workspace { get; set; }

        /// <summary>
        /// Identifier for task
        /// </summary>
        [JsonProperty("id")]
        public required string? Id { get; set; }

        /// <summary>
        /// Name of task
        /// </summary>
        [JsonProperty("name")]
        public required string? Name { get; set; }

        /// <summary>
        /// Description of task
        /// </summary>
        [JsonProperty("description")]
        public required string? Description { get; set; }

        /// <summary>
        /// Date the task is due
        /// </summary>
        [JsonProperty("dueDate")]
        public required DateTime? DueDate { get; set; }

        /// <summary>
        /// Default = SOFT.  Available options are SOFT, HARD, NONE
        /// </summary>
        [JsonProperty("deadlineType")]
        public required string? DeadlineType { get; set; }

        /// <summary>
        /// Parent recurring task id
        /// </summary>
        [JsonProperty("parentRecurringTaskId")]
        public required string? ParentRecurringTaskId { get; set; }

        /// <summary>
        /// Is the task completed
        /// </summary>
        [JsonProperty("completed")]
        public required bool? Completed { get; set; }

        /// <summary>
        /// The user that created this task
        /// </summary>
        [JsonProperty("creator")]
        public required User? Creator { get; set; }

        /// <summary>
        /// Project task belongs to
        /// </summary>
        [JsonProperty("project")]
        public required Project? Project { get; set; }

        /// <summary>
        /// Status of task
        /// </summary>
        [JsonProperty("status")]
        public required Status? Status { get; set; }

        /// <summary>
        /// Available options are Low, Medium, High, ASAP
        /// </summary>
        [JsonProperty("priority")]
        public required string? Priority { get; set; }

        /// <summary>
        /// Labels associated with task
        /// </summary>
        [JsonProperty("labels")]
        public required List<Label>? Labels { get; set; }

        /// <summary>
        /// Users assigned to task
        /// </summary>
        [JsonProperty("assignees")]
        public required List<User>? Assignees { get; set; }

        /// <summary>
        /// The time that motion has scheduled this task to start
        /// </summary>
        [JsonProperty("scheduledStart", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ScheduledStart { get; set; }

        /// <summary>
        /// The time that motion has scheduled this task to end
        /// </summary>
        [JsonProperty("scheduledEnd", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ScheduledEnd { get; set; }

        /// <summary>
        /// Returns true if Motion was unable to schedule this task. Check Motion directly to address
        /// </summary>
        [JsonProperty("schedulingIssue")]
        public required bool? SchedulingIssue { get; set; }
    }
}