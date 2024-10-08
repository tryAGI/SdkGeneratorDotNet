﻿//HintName: G.Models.ScalingConfigPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tag type for marking schemas for patching.<br/>
    /// A Patchable schema is one used for updating other schemas.
    /// </summary>
    public sealed partial class ScalingConfigPatch
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ScalingConfigType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args")]
        public global::G.ScalingConfigPatchArgs? Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minimum_nodes")]
        public int? MinimumNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum_nodes")]
        public int? MaximumNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}