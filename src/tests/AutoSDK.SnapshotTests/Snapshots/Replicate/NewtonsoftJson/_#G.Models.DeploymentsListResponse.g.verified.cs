﻿//HintName: G.Models.DeploymentsListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsListResponse
    {
        /// <summary>
        /// A URL pointing to the next page of deployment objects if any
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next")]
        public string? Next { get; set; }

        /// <summary>
        /// A URL pointing to the previous page of deployment objects if any
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// An array containing a page of deployment objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.DeploymentsListResponseResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}