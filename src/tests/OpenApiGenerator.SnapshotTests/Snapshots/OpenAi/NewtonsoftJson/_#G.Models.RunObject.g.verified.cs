﻿//HintName: G.Models.RunObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an execution run on a [thread](/docs/api-reference/threads).
    /// </summary>
    public sealed partial class RunObject
    {
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `thread.run`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public RunObjectObject Object { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// The ID of the [thread](/docs/api-reference/threads) that was executed on as a part of this run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThreadId { get; set; } = default!;

        /// <summary>
        /// The ID of the [assistant](/docs/api-reference/assistants) used for execution of this run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssistantId { get; set; } = default!;

        /// <summary>
        /// The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, or `expired`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public RunObjectStatus Status { get; set; } = default!;

        /// <summary>
        /// Details on the action required to continue the run. Will be `null` if no action is required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_action", Required = global::Newtonsoft.Json.Required.Always)]
        public RunObjectRequiredAction? RequiredAction { get; set; } = default!;

        /// <summary>
        /// The last error associated with this run. Will be `null` if there are no errors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_error", Required = global::Newtonsoft.Json.Required.Always)]
        public RunObjectLastError? LastError { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int? ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int? StartedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was cancelled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int? CancelledAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int? FailedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int? CompletedAt { get; set; } = default!;

        /// <summary>
        /// Details on why the run is incomplete. Will be `null` if the run is not incomplete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("incomplete_details", Required = global::Newtonsoft.Json.Required.Always)]
        public RunObjectIncompleteDetails? IncompleteDetails { get; set; } = default!;

        /// <summary>
        /// The model that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The instructions that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// The list of tools that the [assistant](/docs/api-reference/assistants) used for this run.
        /// <br/>Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Tools { get; set; } = default!;

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public RunObjectMetadata? Metadata { get; set; } = default!;

        /// <summary>
        /// Usage statistics related to the run. This value will be `null` if the run is not in a terminal state (i.e. `in_progress`, `queued`, etc.).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public RunCompletionUsage? Usage { get; set; } = default!;

        /// <summary>
        /// The sampling temperature used for this run. If not set, defaults to 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The nucleus sampling value used for this run. If not set, defaults to 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// The maximum number of prompt tokens specified to have been used over the course of the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int? MaxPromptTokens { get; set; } = default!;

        /// <summary>
        /// The maximum number of completion tokens specified to have been used over the course of the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int? MaxCompletionTokens { get; set; } = default!;

        /// <summary>
        /// Controls for how a thread will be truncated prior to the run. Use this to control the intial context window of the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncation_strategy", Required = global::Newtonsoft.Json.Required.Always)]
        public TruncationObject TruncationStrategy { get; set; } = default!;

        /// <summary>
        /// Controls which (if any) tool is called by the model.
        /// `none` means the model will not call any tools and instead generates a message.
        /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.
        /// `required` means the model must call one or more tools before responding to the user.
        /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice", Required = global::Newtonsoft.Json.Required.Always)]
        public AssistantsApiToolChoiceOption ToolChoice { get; set; } = default!;

        /// <summary>
        /// Specifies the format that the model must output. Compatible with [GPT-4 Turbo](/docs/models/gpt-4-and-gpt-4-turbo) and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format", Required = global::Newtonsoft.Json.Required.Always)]
        public AssistantsApiResponseFormatOption ResponseFormat { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}