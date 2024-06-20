﻿//HintName: G.VectorStoresClient.ListVectorStoreFiles.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        /// <summary>
        /// Returns a list of vector store files.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListVectorStoreFilesResponse> ListVectorStoreFilesAsync(
            string vectorStoreId,
            int limit,
            global::G.ListVectorStoreFilesOrder order,
            string after,
            string before,
            global::G.ListVectorStoreFilesFilter filter,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/vector_stores/{vectorStoreId}/files?limit={limit}&order={order}&after={after}&before={before}&filter={filter}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListVectorStoreFilesResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}