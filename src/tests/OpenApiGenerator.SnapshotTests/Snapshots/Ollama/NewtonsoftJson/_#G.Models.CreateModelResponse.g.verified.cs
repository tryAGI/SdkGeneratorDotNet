﻿//HintName: G.Models.CreateModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response object for creating a model. When finished, `status` is `success`.
    /// </summary>
    public sealed partial class CreateModelResponse
    {
        /// <summary>
        /// Status creating the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public CreateModelStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}