﻿//HintName: G.Models.WebhooksSecurityAdvisory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details of the security advisory, including summary, description, and severity.
    /// </summary>
    public sealed partial class WebhooksSecurityAdvisory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cvss", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksSecurityAdvisoryCvss Cvss { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryCwe> Cwes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ghsa_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GhsaId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublishedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("references", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryReference> References { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public string Severity { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksSecurityAdvisoryVulnerabilitie> Vulnerabilities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("withdrawn_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? WithdrawnAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}