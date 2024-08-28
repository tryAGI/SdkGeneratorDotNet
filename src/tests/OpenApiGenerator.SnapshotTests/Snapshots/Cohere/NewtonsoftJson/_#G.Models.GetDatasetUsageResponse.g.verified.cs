﻿//HintName: G.Models.GetDatasetUsageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetUsageResponse
    {
        /// <summary>
        /// The total number of bytes used by the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_usage")]
        public double OrganizationUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}