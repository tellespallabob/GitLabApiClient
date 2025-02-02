﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Releases.Requests
{
    /// <summary>
    /// Used to update releases in a project
    /// </summary>
    public sealed class UpdateReleaseRequest
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }
        [JsonProperty("tag_name")]
        public string TagName { get; set; }
        [JsonProperty("name")]
        public string ReleaseName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("released_at")]
        public DateTime? ReleasedAt { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReleaseRequest"/> class
        /// </summary>
        /// <param name="projectId">The ID or URL-encoed path of the project.</param>
        /// <param name="releaseName">The name for the release</param>
        /// <param name="tagName">The name of the tag, the release will be created from</param>
        /// <param name="description">The description for the release.</param>
        /// <param name="releasedAt">The date the release will be/was ready.</param>
        public UpdateReleaseRequest(string projectId, string releaseName, string tagName, string description, DateTime? releasedAt = null)
        {
            ProjectId = projectId;
            ReleaseName = releaseName;
            TagName = tagName;
            Description = description;
            ReleasedAt = releasedAt;
        }
    }
}
