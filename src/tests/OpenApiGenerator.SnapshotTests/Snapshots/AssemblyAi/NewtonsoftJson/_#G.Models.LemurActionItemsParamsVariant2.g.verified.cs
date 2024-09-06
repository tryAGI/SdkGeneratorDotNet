﻿//HintName: G.Models.LemurActionItemsParamsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurActionItemsParamsVariant2
    {
        /// <summary>
        /// How you want the action items to be returned. This can be any text.<br/>
        /// Defaults to "Bullet Points".<br/>
        /// Default Value: Bullet Points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer_format")]
        public string? AnswerFormat { get; set; } = "Bullet Points";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}