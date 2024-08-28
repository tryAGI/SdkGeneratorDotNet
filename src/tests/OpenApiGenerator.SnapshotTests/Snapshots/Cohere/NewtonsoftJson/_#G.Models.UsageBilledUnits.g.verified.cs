﻿//HintName: G.Models.UsageBilledUnits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageBilledUnits
    {
        /// <summary>
        /// The number of billed input tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens")]
        public double InputTokens { get; set; }

        /// <summary>
        /// The number of billed output tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens")]
        public double OutputTokens { get; set; }

        /// <summary>
        /// The number of billed search units.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_units")]
        public double SearchUnits { get; set; }

        /// <summary>
        /// The number of billed classifications units.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classifications")]
        public double Classifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}