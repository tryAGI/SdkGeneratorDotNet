﻿//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.smith.langchain.com";

        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings();


        /// <summary>
        /// 
        /// </summary>
        public TracerSessionsClient TracerSessions => new TracerSessionsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrgsClient Orgs => new OrgsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth => new AuthClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeyClient ApiKey => new ApiKeyClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExamplesClient Examples => new ExamplesClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RunClient Run => new RunClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback => new FeedbackClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PublicClient Public => new PublicClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues => new AnnotationQueuesClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TenantClient Tenant => new TenantClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InfoClient Info => new InfoClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedbackConfigsClient FeedbackConfigs => new FeedbackConfigsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelPriceMapClient ModelPriceMap => new ModelPriceMapClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsClient UsageLimits => new UsageLimitsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TtlSettingsClient TtlSettings => new TtlSettingsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundSettingsClient PlaygroundSettings => new PlaygroundSettingsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServiceAccountsClient ServiceAccounts => new ServiceAccountsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChartsClient Charts => new ChartsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ReposClient Repos => new ReposClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LikesClient Likes => new LikesClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommitsClient Commits => new CommitsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings => new SettingsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EventsClient Events => new EventsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments => new CommentsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}