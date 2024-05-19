﻿//HintName: G.Api.EndPoints.ListVectorStoreFiles.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Returns a list of vector store files.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ListVectorStoreFilesResponse> ListVectorStoreFilesAsync(
            string vectorStoreId,
            int limit,
            string order,
            string after,
            string before,
            string filter,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: $"/vector_stores/{vectorStoreId}/files?limit={limit}&order={order}&after={after}&before={before}&filter={filter}");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ListVectorStoreFilesResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}