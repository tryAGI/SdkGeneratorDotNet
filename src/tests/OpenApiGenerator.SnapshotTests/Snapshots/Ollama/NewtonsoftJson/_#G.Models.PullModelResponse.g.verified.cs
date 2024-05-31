﻿//HintName: G.Models.PullModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response class for pulling a model. 
    /// The first object is the manifest. Then there is a series of downloading responses. Until any of the download is completed, the `completed` key may not be included. 
    /// The number of files to be downloaded depends on the number of layers specified in the manifest.
    /// </summary>
    public sealed partial class PullModelResponse
    {
        /// <summary>
        /// Status pulling the model.
        /// <br/>Example: pulling manifest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public PullModelStatus? Status { get; set; }

        /// <summary>
        /// The model's digest.
        /// <br/>Example: sha256:bc07c81de745696fdf5afca05e065818a8149fb0c77266fb584d9b2cba3711a
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Total size of the model.
        /// <br/>Example: 2142590208
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public long Total { get; set; }

        /// <summary>
        /// Total bytes transferred.
        /// <br/>Example: 2142590208
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public long Completed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}