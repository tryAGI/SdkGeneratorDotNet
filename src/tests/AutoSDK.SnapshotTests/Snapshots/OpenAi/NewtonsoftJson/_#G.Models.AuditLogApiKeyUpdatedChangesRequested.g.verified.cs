﻿//HintName: G.Models.AuditLogApiKeyUpdatedChangesRequested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to update the API key.
    /// </summary>
    public sealed partial class AuditLogApiKeyUpdatedChangesRequested
    {
        /// <summary>
        /// A list of scopes allowed for the API key, e.g. `["api.model.request"]`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}