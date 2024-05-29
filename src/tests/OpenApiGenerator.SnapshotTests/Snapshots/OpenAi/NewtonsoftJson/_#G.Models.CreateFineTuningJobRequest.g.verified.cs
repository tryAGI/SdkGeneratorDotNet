﻿//HintName: G.Models.CreateFineTuningJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFineTuningJobRequest
    {
        /// <summary>
        /// The name of the model to fine-tune. You can select one of the
        /// [supported models](/docs/guides/fine-tuning/what-models-can-be-fine-tuned).
        /// <br/>Example: gpt-3.5-turbo
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.AnyOf<string, CreateFineTuningJobRequestModel> Model { get; set; } = default!;

        /// <summary>
        /// The ID of an uploaded file that contains training data.
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// <br/>Example: file-abc123
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_file", Required = global::Newtonsoft.Json.Required.Always)]
        public string TrainingFile { get; set; } = default!;

        /// <summary>
        /// The hyperparameters used for the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparameters")]
        public CreateFineTuningJobRequestHyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// A string of up to 18 characters that will be added to your fine-tuned model name.
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-3.5-turbo:openai:custom-model-name:7p4lURel`.
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// The ID of an uploaded file that contains validation data.
        /// If you provide this file, the data is used to generate validation
        /// metrics periodically during fine-tuning. These metrics can be viewed in
        /// the fine-tuning results file.
        /// The same data should not be present in both train and validation files.
        /// Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
        /// <br/>Example: file-abc123
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// A list of integrations to enable for your fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integrations")]
        public global::System.Collections.Generic.IList<CreateFineTuningJobRequestIntegrations?>? Integrations { get; set; }

        /// <summary>
        /// The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.
        /// If a seed is not specified, one will be generated for you.
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}