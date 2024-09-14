﻿//HintName: G.SearchClient.SearchLabels.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        partial void PrepareSearchLabelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int repositoryId,
            ref string q,
            ref global::G.SearchLabelsSort? sort,
            ref global::G.SearchLabelsOrder? order,
            ref int perPage,
            ref int page);
        partial void PrepareSearchLabelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int repositoryId,
            string q,
            global::G.SearchLabelsSort? sort,
            global::G.SearchLabelsOrder? order,
            int perPage,
            int page);
        partial void ProcessSearchLabelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchLabelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search labels<br/>
        /// Find labels in a repository with names or descriptions that match search keywords. Returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).<br/>
        /// When searching for labels, you can get text match metadata for the label **name** and **description** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).<br/>
        /// For example, if you want to find labels in the `linguist` repository that match `bug`, `defect`, or `enhancement`. Your query might look like this:<br/>
        /// `q=bug+defect+enhancement&amp;repository_id=64778136`<br/>
        /// The labels that best match the query appear first in the search results.
        /// </summary>
        /// <param name="repositoryId"></param>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchLabelsResponse> SearchLabelsAsync(
            int repositoryId,
            string q,
            global::G.SearchLabelsSort? sort = default,
            global::G.SearchLabelsOrder? order = global::G.SearchLabelsOrder.Desc,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSearchLabelsArguments(
                httpClient: _httpClient,
                repositoryId: ref repositoryId,
                q: ref q,
                sort: ref sort,
                order: ref order,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/search/labels?repository_id={repositoryId}&q={q}&sort={(global::System.Uri.EscapeDataString(sort?.ToValueString() ?? string.Empty))}&order={(global::System.Uri.EscapeDataString(order?.ToValueString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSearchLabelsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                repositoryId: repositoryId,
                q: q,
                sort: sort,
                order: order,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSearchLabelsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSearchLabelsResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.SearchLabelsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}