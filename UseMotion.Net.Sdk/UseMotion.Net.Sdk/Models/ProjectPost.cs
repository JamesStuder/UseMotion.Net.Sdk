﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models
{
    public class ProjectPost
    {
        /// <summary>
        /// ISO 8601 Due date on the task. Example: 2023-04-20T15:02:30.310-06:00
        /// </summary>
        [JsonProperty("dueDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Name of the project
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Linked workspace id
        /// </summary>
        [JsonProperty("workspaceId")]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Description of the project
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; }

        /// <summary>
        /// Labels for the project
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Labels { get; set; }

        /// <summary>
        /// Status of the project
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; }

        /// <summary>
        /// Priority of the project. Can be one of: ASAP, HIGH, MEDIUM, LOW
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string? Priority { get; set; }
    }
}